
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_08.Tests;

[TestClass]
public class ProgramTests
{
    public const string Initial = "T";
    public static string Expected = $"""
        输入你的全名 (例：Inigo T. Montoya): <<{Inigo} {Initial}. {Montoya}
        >>
        FirstName: {Inigo}
        Initial: {Initial}
        LastName: {Montoya}
        """;

    [TestMethod]
    public void Main_WriteMyName()
    {
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(Expected,
            Program.Main);
    }
}
