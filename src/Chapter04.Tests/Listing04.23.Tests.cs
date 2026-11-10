using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_23.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputOfNegative1_Exit()
    {
        const string expected =
            @"退出...";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("-1"));
    }
    
    [TestMethod]
    public void Main_Input10_AnswerTooHigh()
    {
        const string expected = 
            @"井字棋最大轮数小于10";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("10"));
    }
    
    [TestMethod]
    public void Main_Input5_AnswerTooLow()
    {
        const string expected = 
            @"井字棋最大轮数大于5";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("5"));
    }

    [TestMethod]
    public void Main_Input9_CorrectAnswer()
    {
        const string expected = 
            @"正确，井字棋最多只能走9轮。";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("9"));
    }
}
