
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_04.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputInigoMontoya_WriteFullName()
    {
        string view =
@"嘿，你！
请输入你的名字: <<Inigo
>>请输入你的姓氏: <<Montoya
>>你好，Inigo Montoya！ 你的姓名缩写是I. M";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
        () =>
        {
            IntroducingMethods.Main();
        });
    }
}
