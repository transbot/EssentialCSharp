
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_20.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputInigoMontoya_WriteLastFirst()
    {
        const string expected =
@"嘿，你！
请输入你的名字: <<Inigo
>>请输入你的姓氏: <<Montoya
>>你的全名是Montoya, Inigo。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
