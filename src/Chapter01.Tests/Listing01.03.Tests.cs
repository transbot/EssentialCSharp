
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_03.Tests;

[TestClass]
public class HelloWorldTests
{
    [TestMethod]
    public void Main_UpDown()
    {
        const string expected =
@"上
下";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, HelloWorld.Main);
    }
}
