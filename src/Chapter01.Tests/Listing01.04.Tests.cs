
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_04.Tests;

[TestClass]
public class HelloWorldTests
{
    [TestMethod]
    public void Main_InigoHello()
    {
        const string expected =
            @"上
中
下";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, HelloWorld.Main);
    }
}
