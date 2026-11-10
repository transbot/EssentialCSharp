
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_03.Tests;

[TestClass]
public class DivisionTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"输入分子: <<42
>>输入分母: <<5
>>42 / 5 = 商8余2。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Division.Main);
    }
}