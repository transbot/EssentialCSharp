using System.Text.RegularExpressions;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void AsyncVoidReturnTest()
    {
        string expected = $@"正在调用Task.Run...(线程ID: *)
正在运行任务... (线程ID: *)
已调用Post通知...(线程ID: *)*
正在抛出预期的异常....(线程ID: *)
已抛出预期的异常System.Exception: 预期的异常
   *。(线程ID: *)";

        string output = IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(
            expected,
            () =>
            {
                Program.Main();
            }
        );

        Assert.IsTrue(Program.EventTriggered);

        Console.WriteLine(output);

        // Verify that only the '正在运行任务...' thread id (the second line), is unique
        MatchCollection matches = Regex.Matches(output, @"\(线程ID: (\d)+\)");
        int firstThreadId = int.Parse(matches[0].Groups[1].Value);
        int secondThreadId = int.Parse(matches[1].Groups[1].Value);
        int? expectedThreadId;
        for (int i = 0; i < matches.Count; i++)
        {
            switch (i)
            {
                case 0:
                case 4:
                case 5:
                    expectedThreadId = firstThreadId;
                    break;
                case 1:
                    // Obviously
                    expectedThreadId = secondThreadId;
                    break;
                default:
                    // Unknown
                    expectedThreadId = null;
                    break;
            }
            if (expectedThreadId is not null)
            {
                Assert.AreEqual<int?>(expectedThreadId, int.Parse(matches[i].Groups[1].Value),
                    $"Match {i} was '{matches[i].Groups[0].Value}' when '{expectedThreadId}' was expected");
            }
        }
        Assert.IsTrue(matches.Count >= 5, "There were not as many 'Thread Id' matches as expected.");
    }
}
