
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_35.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_TryParseStringValidNumber_CorrectlyParsed()
    {
        const string expected =
            @"输入一个数字: <<42>>";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }

    [TestMethod]
    public void Main_TryParseStringNonNumber_IncorrectInput()
    {
        const string expected =
@"输入一个数字: <<forty-two
>>输入的文本不是一个有效的数字。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
