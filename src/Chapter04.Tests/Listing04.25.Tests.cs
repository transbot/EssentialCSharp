
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_25.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected =
$@"输入圆的半径: <<3
>>这个圆的面积是: {28.27}";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, CircleAreaCalculator.Main);
    }
}
