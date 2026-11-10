
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"按Enter键关闭。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}