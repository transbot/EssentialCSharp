namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_34.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_TryParseThreadLevelPriorityEnumToStringUsing()
    {
        const string expected = "Idle";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
