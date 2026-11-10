
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_24.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"开始...
MethodA()正在执行...
结束...";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
