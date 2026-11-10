
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_20.Tests;

[TestClass]
public class FortyTwoTests
{
    [TestMethod]
    public void Main_AdditionOperatorWithNonNumericType_StringConcatenated()
    {
        const string expected = 
@"华盛顿州原来的塔科马大桥
被风速为67公里/小时的大风摧毁。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, FortyTwo.Main);
    }
}
