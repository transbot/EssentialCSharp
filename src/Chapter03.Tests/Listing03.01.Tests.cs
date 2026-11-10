
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_01.Tests;

[TestClass]
public class UppercaseTests
{
    [TestMethod]
    public void Main_GivenArgs_NumberDoubles()
    {
        string[] args = { "arg0", "arg1" };
        string expected =
            $"你在命令行提供的第一个参数包括{args[0].Length}个字符/字。{Environment.NewLine}\'number\'的两倍是{args[0].Length * 2}。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, ()=>Program.Main(args));
    }

    [TestMethod]
    public void Main_GivenValidString_MakeUppercase()
    {
        string[] args = System.Array.Empty<string>();
        const string expected =
            "需要为\'number\'提供一个值，不允许为null。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, () => Program.Main(args));
    }
}