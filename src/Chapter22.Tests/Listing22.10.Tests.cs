
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_10.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"应用程序已启动...
正在启动任务...
DoWork()已启动....
在线程执行期间等待...
DoWork()正在结束....
线程已结束
应用程序关闭...";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}