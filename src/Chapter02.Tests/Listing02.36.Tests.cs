
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_36.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_UsingTryParseWithInlineOut_Pi()
    {
        string expected = $"输入一个数字: <<{System.Math.PI}>>输入被成功解析成数字: {System.Math.PI}.>>{Environment.NewLine}'number'目前的值是: { System.Math.PI }";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);

    }

    [TestMethod]
    public void Main_UsingTryParseWithInlineOut_Pie()
    {
        string expected = @$"输入一个数字: <<pie>>输入的文本不是一个有效的数字。
'number'目前的值是: { default(int) }";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);

    }
}
