
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_22.Tests;

[TestClass]
public class PalindromeLengthTests
{
    [TestMethod]
    public void Main_InputRacecar_OutputPalindromeSevenChars()
    {
        const string expected =
@"输入一句回文: <<racecar
>>回文""racecar""共有 7个字。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, PalindromeLength.Main);
    }
}
