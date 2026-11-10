
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_14.Tests;

[TestClass]
public class MiracleMaxTests
{
    [TestMethod]
    public void Main_StormCastleLong()
    {
        const string expected =
@"愉快地袭击古堡吧！
你觉得可以吗?
这需要奇迹。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, StormingTheCastle.Main);
    }
}
