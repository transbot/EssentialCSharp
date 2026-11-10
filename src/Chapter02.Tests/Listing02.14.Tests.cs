
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_14.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Main_WriteTriangle()
    {
        const string expected = @"开始
                   /\
                  /  \
                 /    \
                /      \
               /________\
结束";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Triangle.Main);
    }
}