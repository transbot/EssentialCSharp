using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_24.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_Input0_ExitProgram()
    {
        const string expected =
            "退出";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("0"));
    }

    [TestMethod]
    public void Main_Input10_ProgramDoesNotExit()
    {
        const string expected =
            "";

        ConsoleAssert.Expect(
            expected, ()=>Program.Main("10"));
    }
}
