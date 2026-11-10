
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_19.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputInigoMontoya_WriteFirstLast()
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
