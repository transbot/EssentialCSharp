
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_02.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"{-33940505930933M}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}