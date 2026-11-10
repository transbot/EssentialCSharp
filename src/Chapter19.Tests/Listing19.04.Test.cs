
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_04.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ObservingUnhandledExceptionsWithContinueWith()
    {
        string expected = "任务状态: Completed";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}