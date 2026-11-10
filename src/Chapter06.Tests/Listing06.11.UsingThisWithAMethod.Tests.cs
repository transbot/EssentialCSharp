namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_11.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_AccessMethodWithThis_WriteMethodResult()
    {
        const string expected =
            @"姓名更改为'Inigo Montoya'";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
