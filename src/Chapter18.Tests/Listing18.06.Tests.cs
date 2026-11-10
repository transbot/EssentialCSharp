
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_06.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"类型参数: System.Int32";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}