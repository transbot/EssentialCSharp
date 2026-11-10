
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_23.Tests;

[TestClass]
public class UppercaseTests
{
    [TestMethod]
    public void Main_InputLorem_OutputNotCapitalized()
    {
        const string expected =
@"输入文本: <<Lorem
>>Lorem";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Uppercase.Main);
    }
}
