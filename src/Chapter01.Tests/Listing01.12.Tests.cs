
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_12.Tests;

[TestClass]
public class MiracleMaxTests
{
    [TestMethod]
    public void Main_StormCastleShort()
    {
        const string expected = @"愉快地袭击古堡吧！";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, MiracleMax.Main);
    }
}
