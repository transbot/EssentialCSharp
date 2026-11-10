
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_22.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected =
@"<<9>>井字棋最多能走多少步? (输入0退出): 正确，井字棋最多只能走9步。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, TicTacToeTrivia.Main);
    }
}
