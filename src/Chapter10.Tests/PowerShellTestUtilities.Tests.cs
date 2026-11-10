using System.Text;
using AddisonWesley.Michaelis.EssentialCSharp.Shared.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Tests;

[TestClass]
public class PowerShellTestUtilitiesTests
{
    [TestMethod]
    public void RunPowerShellScript_PreservesChineseOutputAndDrainsBothPipes()
    {
        const string greeting = "中文输出：你好，GitHub。";
        const string errorChunk = "错误流数据。";
        const int repeats = 20_000;
        string scriptPath = Path.Combine(Path.GetTempPath(), $"UTF8 '{Guid.NewGuid():N}' 中文.ps1");
        try
        {
            File.WriteAllText(scriptPath, $"""
                [Console]::WriteLine('{greeting}')
                [Console]::Error.Write(('{errorChunk}' * {repeats}))
                """, new UTF8Encoding(encoderShouldEmitUTF8Identifier: true));
            int exitCode = PowerShellTestUtilities.RunPowerShellScript(scriptPath, string.Empty, out string output);
            Assert.AreEqual(0, exitCode);
            string expectedError = string.Concat(Enumerable.Repeat(errorChunk, repeats));
            string expected = greeting + Environment.NewLine + Environment.NewLine
                + "ERROR: " + Environment.NewLine + expectedError;
            Assert.AreEqual(expected.Length, output.Length, "Child output was truncated or decoded incorrectly.");
            Assert.IsTrue(string.Equals(expected, output, StringComparison.Ordinal),
                "Chinese stdout and the stderr payload larger than the pipe buffer must be captured exactly.");
        }
        finally
        {
            File.Delete(scriptPath);
        }
    }
}
