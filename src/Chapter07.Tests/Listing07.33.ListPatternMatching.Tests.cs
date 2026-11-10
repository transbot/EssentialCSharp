

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_33.Tests;

[TestClass]
public class ProgramTests
{

    [TestMethod]
    [DataRow("help")]
    [DataRow("h")]
    [DataRow("?")]
    [DataRow("<invalid>")]
    public void ParseHelpCommand(string command)
    {
        foreach (string item in PrefixCommands(command))
        {
            command = item;
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                "命令帮助...", () => Program.Main(new[] { command }));
        }
    }

    [TestMethod]
    [DataRow("cat", @"..\SampleFile.txt")]
    [DataRow("c", @"..\SampleFile.txt")]
    public void ParseCatCommand(string command, string fileName)
    {
        foreach (string item in PrefixCommands(command))
        {
            command = $"{item}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                $"编录 '{fileName}'...", () => Program.Main(new[] { command, fileName }));
        }
    }


    [TestMethod]
    [DataRow("copy", @"..\source.txt", @"..\target.txt")]
    public void ParseCopyCommand(string command, string sourceFile, string targetFile)
    {
        foreach (string item in PrefixCommands(command))
        {
            command = $"{item}";
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                $"复制 '{sourceFile}' '{targetFile}'...", () => Program.Main(new[] { command, sourceFile, targetFile }));
        }
    }

    private static IEnumerable<string> PrefixCommands(string command)
    {
        if (command.Length == 1)
        {
            yield return $"/{command}";
            yield return $"-{command}";
        }
        else
        {
            yield return $"--{command}";
        }
    }


}
