
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void UsingListOfT()
    {
        const string expected =
            "按字母顺序，Bashful是第一个小矮人，而Sneezy是最后一个。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}