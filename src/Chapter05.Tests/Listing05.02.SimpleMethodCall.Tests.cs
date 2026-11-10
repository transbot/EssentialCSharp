
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_02.Tests;

[TestClass]
public class HeyYouTests
{
    [TestMethod]
    public void Main_MethodCalls_MethodsCalledSuccessfully()
    {
        const string expected =
@"嘿，你！
请输入你的名字: <<Inigo
>>请输入你的姓氏: <<Montoya
>>你的全名是Inigo Montoya。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, HeyYou.Main);
    }
}
