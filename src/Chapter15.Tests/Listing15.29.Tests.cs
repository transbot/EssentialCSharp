
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"{ TeamName = 法国, Players = System.String[] }
{ TeamName = 意大利, Players = System.String[] }";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}