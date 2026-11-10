
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_08.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"请输入一个整数: ''不是一个有效的整数。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, DelegateSample.Main);
    }
}