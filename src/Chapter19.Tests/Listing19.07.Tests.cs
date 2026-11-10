namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_07.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ValueTaskAsyncReturnTest()
    {
        string expected =
@"睡眠2000毫秒
抛出异常。
正在启动事件处理程序.
睡眠4000毫秒
唤醒
正在运行finally块。";

        string output = IntelliTect.TestTools.Console.ConsoleAssert.Execute(string.Empty,
        Program.Main).TrimEnd();

        // Assert that all expected lines are present.
        Assert.IsTrue(expected.Split(Environment.NewLine).All(output.Contains));

        // Assert that the thread ID (first number in each line) is not the same for all lines.
        Assert.AreEqual(2, output.Split(Environment.NewLine).Select(
            line => line.Split(':')[0]).Distinct().Count());
    }
}