
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"输入温度: '' 不是一个有效的整数。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
