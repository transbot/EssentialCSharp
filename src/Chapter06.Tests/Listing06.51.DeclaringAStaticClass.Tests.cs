
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_51.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest_ArgsHasZeroElements_ThrowException()
    {
        Assert.ThrowsException<ArgumentException>(
            () => Program.Main(Array.Empty<string>()));
    }

    [TestMethod]
    public void MainTest()
    {
        const string expected = @"最长的实参长度 = 10
最短的实参长度 = 2";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, () =>
            {
                Program.Main(
                    new string[] {
                        "C#", "C++", "Java", "JavaScript", "COBOL" });
            });
    }
}
