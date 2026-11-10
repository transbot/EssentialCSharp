
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string expected = $@"专利数量: 8{Environment.NewLine}19世纪专利数量: 4";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}