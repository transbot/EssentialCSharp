
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_05.Tests;

[TestClass]
public class HelloWorldTests
{
    [TestMethod]
    public void Main_InigoHello()
    {
        const string expected = 
            @"你好，我叫Inigo Montoya。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, HelloWorld.Main);
    }
}
