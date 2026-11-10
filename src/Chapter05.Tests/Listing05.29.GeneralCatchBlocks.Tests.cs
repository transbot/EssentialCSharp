
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_HappyPath()
    {
        string expected = @"请输入你的名字: <<Inigo
>>请输入你的年龄: <<42
>>你好，Inigo！你有504个月大了。
再见，Inigo。";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            ExceptionHandling.Main();
        });
    }

    [TestMethod]
    public void Main_GivenInvalidAge_ThrowException()
    {
        string expected = @"请输入你的名字: <<Inigo
>>请输入你的年龄: <<forty-two
>>你输入的年龄'forty-two'不是一个有效的整数。
再见，Inigo。";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            ExceptionHandling.Main();
        });
    }
}
