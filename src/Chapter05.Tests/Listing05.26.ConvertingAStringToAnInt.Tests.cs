
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_26.Tests;

[TestClass]
public class ExceptionHandlingTests
{
    [TestMethod]
    public void Main_InputNameAge_ExpectMonthCount()
    {
        string view =
@"嘿，你！
请输入你的名字: <<Inigo
>>请输入你的年龄: <<10
>>你好，Inigo！你有120个月大了。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
        () =>
        {
            ExceptionHandling.Main();
        });
    }
}
