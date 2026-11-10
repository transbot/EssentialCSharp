
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_13.Tests;

[TestClass]
public class HelloWorldTests
{
    [TestMethod]
    public void Main_InigoMantra_ProperOutput()
    {
        const string expected =
@"你好，我叫Inigo Montoya。
你杀害了我的父亲....";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, HelloWorld.Main);
    }
}
