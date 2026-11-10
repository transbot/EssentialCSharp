using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text;

namespace AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

public class PowerShellTestUtilities
{
    private static readonly Mutex Mutext = new (false, typeof(PowerShellTestUtilities).FullName);
    
    public static bool WindowsEnvironment()
    {
        return RuntimeInformation.IsOSPlatform(OSPlatform.Windows);
    }
    
    private static readonly Lazy<string?> _PowerShellCommand = new(() =>
    {
        string? powershellCommand = null;
        // Verify that the PowerShell command executes successfully.
        foreach(string command in 
            new string[]{ "pwsh", WindowsEnvironment() ? "PowerShell" : null!}.Where(item=> item is not null))
        {
            try
            {
                Process powershell = Process.Start(command, "-Version");
                powershell.WaitForExit();
                if (powershell.ExitCode == 0)
                {
                    powershellCommand = command;
                    break;
                }
            }
            catch (System.ComponentModel.Win32Exception)
            {
                powershellCommand = null;
            }
        }
        return powershellCommand;
    });
    public static int RunPowerShellScript(string scriptPath, string arguments) =>
        RunPowerShellScript(scriptPath, arguments, out string _);

    public static int RunPowerShellScript(string scriptPath, string arguments, out string psOutput)
    {
        try
        {
            Mutext.WaitOne();
            if (PowerShellCommand is null)
            {
                throw new InvalidOperationException("PowerShell is not installed");
            }

            if (!System.IO.File.Exists(scriptPath))
            {
                throw new ArgumentException($"scriptPath, '{scriptPath}', not found.", nameof(scriptPath));
            }

            using var powerShell = new Process();
            powerShell.StartInfo.RedirectStandardOutput = true;
            powerShell.StartInfo.RedirectStandardError = true;
            powerShell.StartInfo.RedirectStandardInput = true;
            powerShell.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            powerShell.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            powerShell.StartInfo.UseShellExecute = false;
            powerShell.StartInfo.FileName = PowerShellCommand;
            powerShell.StartInfo.ArgumentList.Add("-NoProfile");
            powerShell.StartInfo.ArgumentList.Add("-NonInteractive");
            powerShell.StartInfo.ArgumentList.Add("-Command");
            string escapedScriptPath = scriptPath.Replace("'", "''");
            powerShell.StartInfo.ArgumentList.Add(
                "[Console]::OutputEncoding = [System.Text.UTF8Encoding]::new($false); "
                + "$OutputEncoding = [Console]::OutputEncoding; "
                + $"& '{escapedScriptPath}' {arguments}");
            powerShell.Start();
            powerShell.StandardInput.Close();
            // Drain both pipes while the child is running. Waiting on stdout first
            // can deadlock when a compiler or cleanup command fills stderr.
            Task<string> outputTask = powerShell.StandardOutput.ReadToEndAsync();
            Task<string> errorTask = powerShell.StandardError.ReadToEndAsync();
            bool exited = powerShell.WaitForExit((int)TimeSpan.FromMinutes(3).TotalMilliseconds);
            if (!exited)
            {
                powerShell.Kill(entireProcessTree: true);
                powerShell.WaitForExit();
            }
            psOutput = outputTask.GetAwaiter().GetResult();
            string errorOutput = errorTask.GetAwaiter().GetResult();
            if (errorOutput.Length > 0)
            {
                psOutput += $"{Environment.NewLine}ERROR: {Environment.NewLine}{errorOutput}";
            }
            if (!exited)
            {
                throw new TimeoutException($"PowerShell script '{scriptPath}' did not finish within three minutes."
                    + Environment.NewLine + psOutput);
            }

            return powerShell.ExitCode;
        }
        finally
        {
            Mutext.ReleaseMutex();
        }
    }

    public static string? PowerShellCommand => _PowerShellCommand.Value;
    public static bool PowerShellNotInstalled => _PowerShellCommand.Value is null;
}
