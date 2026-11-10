
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_31.Tests;

[TestClass]
public class PalindromeTests
{
    [TestMethod]    
    public void Main_InputValidPalindrome_IdentifiedAsPalindrome()
    {
        const string expected =
@"输入一句回文: <<kayak
>>""kayak""是回文。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Palindrome.Main);
    }
    
    [TestMethod]
    public void Main_InputInvalidPalindrome_NotIdentifiedAsPalindrome()
    {
        const string expected =
@"输入一句回文: <<test
>>""test""不是回文。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Palindrome.Main);
    }
}
