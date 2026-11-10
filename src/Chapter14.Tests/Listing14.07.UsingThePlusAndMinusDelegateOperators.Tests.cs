
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_07.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"使用+操作符合并委托:{Environment.NewLine}加热器: Off{Environment.NewLine}冷却器: Off{Environment.NewLine}使用-操作符取消合并委托:{Environment.NewLine}加热器: Off";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
