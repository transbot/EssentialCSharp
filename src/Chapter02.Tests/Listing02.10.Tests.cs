
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_10.Tests;

[TestClass]
public class Comparison
{
    [TestMethod]
    public void Main_WriteBooleanStatements()
    {
        const string expected = "是否请求帮助: True";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}