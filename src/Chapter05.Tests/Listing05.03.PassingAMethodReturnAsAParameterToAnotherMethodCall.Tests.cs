
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_03.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputInigo_WriteHelloInigo()
    {
        const string expected =
        @"请输入你的名字: <<Inigo
>>你好，Inigo！";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
