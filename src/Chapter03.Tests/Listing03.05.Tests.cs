
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_05.Tests;


[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteInventions()
    {
        const string expected =
@"双焦点眼镜 (1784)
留声机 (1877)";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
