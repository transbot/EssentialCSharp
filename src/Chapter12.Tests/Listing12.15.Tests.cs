
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_15.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"1914: 沙克尔顿乘坐“坚忍号”前往南极。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}