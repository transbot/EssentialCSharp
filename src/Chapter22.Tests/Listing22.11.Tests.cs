
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_11.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Decrement中的Count = {-32767.01134}
Main中的Count = {32767.01134}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}