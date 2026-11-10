
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_11.Tests;

[TestClass]
public class DelegateSampleTests
{
    [TestMethod]
    public void Main()
    {
        string expected =
        @"请输入一个整数: <<1
>>请输入一个整数: <<12
>>请输入一个整数: <<13
>>请输入一个整数: <<5
>>请输入一个整数: <<4
>>1
12
13
4
5
";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            DelegateSample.Main();
        });
    }
}