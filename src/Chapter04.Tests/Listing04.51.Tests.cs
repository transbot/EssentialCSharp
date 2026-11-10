
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_51.Tests;

[TestClass]
public class TicTacToeTests
{
    [TestMethod]
    public void Main_BreakOnPlayerWinning_Player1Winner()
    {
        const string expected =
            @"玩家1是赢家。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, TicTacToe.Main);
    }
}
