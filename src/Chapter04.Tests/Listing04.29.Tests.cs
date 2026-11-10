
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_Input5_BooleanConditionHit()
    {
        const string expected =
            @"井字棋最大步数大于5";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
