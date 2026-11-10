
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_30.Tests;

[TestClass]
public class ThrowingExceptionsTests
{
    [TestMethod]
    public void Main_WriteExecutionData()
    {
        string view =
@"开始执行
抛出异常
非预期的错误: 任意异常
正在关闭...";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
        () =>
        {
            ThrowingExceptions.Main();
        });
    }
}
