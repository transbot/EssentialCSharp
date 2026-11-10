
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_25.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MoreEnumerableMethodCalls()
    {
        string expected =
$@"杂物: System.Object, 1, 3, 5, 7, 9, ""东西"", ????????-????-????-????-????????????
偶数: 0, 2, 4, 6, 8
奇数: 1, 3, 5, 7, 9
奇数和偶数的并集: 0, 2, 4, 6, 8, 1, 3, 5, 7, 9
与偶数的并集: 0, 2, 4, 6, 8, 1, 3, 5, 7, 9
与奇数合并成超集: 0, 2, 4, 6, 8, 1, 3, 5, 7, 9, 1, 3, 5, 7, 9
与偶数的交集: 0, 2, 4, 6, 8
去重: 0, 2, 4, 6, 8, 1, 3, 5, 7, 9
Collection ""SequenceEquals"" numbers.Concat(odd).Distinct())
反转: 9, 7, 5, 3, 1, 8, 6, 4, 2, 0
平均: {4.5}
总和: 45
最大: 9
最小: 0";

        IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
        () =>
        {
            Program.Main();
        });
    }
}
