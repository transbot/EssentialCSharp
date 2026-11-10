
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_23.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_GetCountOnArray_ReturnArrayLength()
    {
        const string expected =
            "数组中有9种语言。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
