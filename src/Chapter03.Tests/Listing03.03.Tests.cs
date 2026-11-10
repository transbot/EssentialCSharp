
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_03.Tests;

[TestClass]
public class UppercaseTests
{
    [TestMethod]
    public void Main_GivenValidString_MakeUppercase()
    {
        const string expected =
@"输入文本: <<test
>>TEST";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Uppercase.Main);
    }
}
