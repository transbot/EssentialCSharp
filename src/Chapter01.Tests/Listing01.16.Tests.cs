
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_16.Tests;

[TestClass]
public class HeyYouTests
{
    [TestMethod]
    public void Main_InputInigoMontoya_WriteNothing()
    {
        const string expected =
@"嘿，你！
请输入你的名字: <<Inigo
>>请输入你的姓氏: <<Montoya
>>";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, HeyYou.Main);
    }
}
