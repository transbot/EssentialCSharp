
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_46.Tests;

[TestClass]
public class BinaryConverterTests
{
    [TestMethod]
    public void Main_Enter0_WriteBinaryEquivalent()
    {
        const string expected =
            @"输入一个整数: <<0
>>0000000000000000000000000000000000000000000000000000000000000000";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, BinaryConverter.Main);
    }
    
    [TestMethod]
    public void Main_Enter1_WriteBinaryEquivalent()
    {
        const string expected =
@"输入一个整数: <<1
>>0000000000000000000000000000000000000000000000000000000000000001";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, BinaryConverter.Main);
    }
    
    [TestMethod]
    public void Main_Enter20_WriteBinaryEquivalent()
    {
        const string expected =
            @"输入一个整数: <<20
>>0000000000000000000000000000000000000000000000000000000000010100";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, BinaryConverter.Main);
    }
}
