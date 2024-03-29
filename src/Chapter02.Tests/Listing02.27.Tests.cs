
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_27.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteOverflowExample()
    {
        const string expected = "-2147483648";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
