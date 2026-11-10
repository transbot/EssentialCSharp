
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_18.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteSwappedVariables()
    {
        string view = @"first = ""再见"", second = ""你好""";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
        () =>
        {
            Program.Main();
        });
    }
}
