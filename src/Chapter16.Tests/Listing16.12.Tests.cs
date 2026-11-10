using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16.Tests;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_12.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void SelectingFollowingGroupClause_UsingTuple()
    {
        ProgramTests.SelectingFollowingGroupClause(Listing16_12.Program.Main);
    }

    public static void SelectingFollowingGroupClause(Action _)
    {
        string expected = $@"
关键字:
 { CSharpExpectedData.ExpectedKeywords }
上下文关键字:
 { CSharpExpectedData.ExpectedContextualKeywords }";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}