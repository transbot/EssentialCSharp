
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_06.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"同时调用两个委托:{Environment.NewLine}加热器: Off{Environment.NewLine}冷却器: On{Environment.NewLine}只调用delegate2{Environment.NewLine}冷却器: Off";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
