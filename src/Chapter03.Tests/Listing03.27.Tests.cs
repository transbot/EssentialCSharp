using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_27.Tests;

[TestClass]
public class ProgrammingLanguagesTests
{
    [TestMethod]
    public void Main_AssertConsoleOutput_MatchesExpected()
    {
        string expected = $"未来的浪潮，COBOL，位于索引2。{Environment.NewLine}{Environment.NewLine}"
            + $"{"第一个元素",-26}\t{"最后一个元素",-26}{Environment.NewLine}"
            + $"{"--------------",-26}\t{"--------------",-26}{Environment.NewLine}"
            + $"{"C#",-26}\t{"TypeScript",-26}{Environment.NewLine}"
            + $"{"TypeScript",-26}\t{"C#",-26}{Environment.NewLine}"
            + $"{string.Empty,-26}\t{string.Empty,-26}{Environment.NewLine}"
            + "Clear后，数组大小是: 9";

        ConsoleAssert.Expect(
            expected, ProgrammingLanguages.Main);
    }
}
