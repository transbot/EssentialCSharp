using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_13.Tests;

[TestClass]
public class DuelOfWitsTests
{
    [TestMethod]
    public void Main_WriteDizzyQuote()
    {
        const string expected = "\"真的，你有令人混乱的智慧。\"\n\"等我做选择吧！\"\n";

        ConsoleAssert.Expect(expected, (Action)DuelOfWits.Main, NormalizeOptions.None);
    }
}