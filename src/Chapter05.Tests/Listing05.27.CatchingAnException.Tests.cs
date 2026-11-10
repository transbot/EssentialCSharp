
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_27.Tests;

[TestClass]
public class ExceptionHandlingTests
{
    [TestMethod]
    public void Main_InputInvalidAge_ExpectInvalidMessage()
    {
        const string expected =
@"嘿，你！
请输入你的名字: <<Inigo
>>请输入你的年龄: <<xyz
>>你输入的年龄'xyz'不是一个有效的整数。
再见，Inigo。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, ExceptionHandling.Main, 1);
    }


    [TestMethod]
    public void Main_InputFifty_ExpectSixHundredMonths()
    {
        const string expected =
@"嘿，你！
请输入你的名字: <<Inigo
>>请输入你的年龄: <<50
>>你好，Inigo！你有600个月大了。
再见，Inigo。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, ExceptionHandling.Main);
    }
}
