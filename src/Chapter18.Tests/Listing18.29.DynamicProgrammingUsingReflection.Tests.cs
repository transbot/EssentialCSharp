
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_29.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"Hello!  My name is Inigo Montoya
{140.6}英里，这是长途铁人三项的总里程。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
