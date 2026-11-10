namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_UsingInsideNamespace_WritesChineseGreeting()
    {
        const string expected = "你好，我的名字是Inigo Montoya。";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Program.Main);
    }
}
