
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_20.Tests;

[TestClass]
public class TriangleTests
{
    [TestMethod]
    public void Main_WriteTriangle()
    {
        const string expected = @"开始
           ____
          /   /\
         /   /  \
        /   /   /\
       /   /   /  \
      /   /   /\   \
     /   /   /  \   \
    /   /   /\   \   \
   /   /   /  \   \   \
  /___/___/____\   \   \
 /     莫比乌斯 \   \   \
/________________\   \   \
\                 \   \  /
 \_________________\___\/
结束";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Triangle.Main);
    }
}
