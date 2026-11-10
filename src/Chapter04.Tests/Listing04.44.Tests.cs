
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_44.Tests;

[TestClass]
public class FibonacciCalculatorTests
{
    [TestMethod]
    public void Main_Enter0_Write1()
    {
        const string expected =
@"输入一个正整数:<<0
>>下一个斐波那契数是1";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, FibonacciCalculator.Main);
    }
    
    [TestMethod]
    public void Main_Enter1_Write1() // returns next number in sequence GREATER than input
    {
        const string expected =
@"输入一个正整数:<<1
>>下一个斐波那契数是2";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, FibonacciCalculator.Main);
    }
    
    [TestMethod]
    public void Main_Enter21_Write34()
    {
        const string expected =
@"输入一个正整数:<<21
>>下一个斐波那契数是34";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, FibonacciCalculator.Main);
    }
}
