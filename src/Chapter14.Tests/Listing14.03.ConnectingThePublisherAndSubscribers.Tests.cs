
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_03.Tests;


[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ConnectingPublisherAndSubscribers()
    {
        string expected = @"输入温度: <<1";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}