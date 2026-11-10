
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_12.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Decrement中的Count = *
Main中的Count = *";

        IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(
            expected, Program.Main);
    }
}