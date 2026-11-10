
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_24.Tests;

[TestClass]
public class UppercaseTests
{
    [TestMethod]
    public void Main_InputLorem_OutputIsCapitalized()
    {
        const string expected =
@"输入文本: <<Lorem
>>LOREM";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Uppercase.Main);
    }
}
