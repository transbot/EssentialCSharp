
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_35.Tests;

[TestClass]
public class LeveragingTryParseTests
{
    [TestMethod]
    public void Main_InputNameAndAge35_AgeProperlyParsed()
    {
        const string expected =
@"请输入你的名字: <<Inigo
>>请输入你的年龄: <<36
>>你好，Inigo！你有432个月大了。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, 
            LeveragingTryParse.Main);
    }

    [TestMethod]
    public void Main_InputNameAndAgeThirtyFive_AgeNotParsed()
    {
        const string expected =
@"请输入你的名字: <<Inigo
>>请输入你的年龄: <<ThirtyFive
>>你输入的年龄'ThirtyFive'不是一个有效的整数。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, LeveragingTryParse.Main);
    }
}
