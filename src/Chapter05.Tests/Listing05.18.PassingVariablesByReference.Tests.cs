
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_18.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteSwappedVariables()
    {
        string view = @"first = ""goodbye"", second = ""hello""";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
        () =>
        {
            Program.Main();
        });
    }
}
