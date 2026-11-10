
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_03.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WithNoParameters_DisplaysHelp()
    {
        string expected = @"
Compress.exe /Out:< 文件名 > /Help /Priority:RealTime | High | AboveNormal | Normal | BelowNormal | Idle";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main(System.Array.Empty<string>());
        });
    }

    [TestMethod]
    public void Main_NormalCompression_Succes()
    {
        string expected = @"Running testhost.dll /Out:output.dat /Priority:High";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main(new string[] {"/Out:output.dat", "/Priority:high"});
        });
    }

    [TestMethod]
    public void Main_InvalidCompression_Succes()
    {
        string expected = @"选项'Invalid'对'Priority'无效。
Compress.exe /Out:< 文件名 > /Help /Priority:RealTime | High | AboveNormal | Normal | BelowNormal | Idle";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main(new string[] { "/Out:output.dat", "/Priority:Invalid" });
        });
    }

}