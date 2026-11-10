
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_17.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputOne_WriteOne()
    {
        const string expected = "随意输入，按Enter键结束：<<1\r>>1";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
