
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_20.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main()
    {
        string expected =
        @"请输入一个整数: <<5
>>请输入一个整数: <<1
>>请输入一个整数: <<4
>>请输入一个整数: <<2
>>请输入一个整数: <<3
>>5
4
3
2
1
items被比较了10次。
";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}