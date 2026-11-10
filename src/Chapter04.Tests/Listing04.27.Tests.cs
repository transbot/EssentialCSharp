
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_27.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = 
$@"圆的面积是: {0.00M}";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
