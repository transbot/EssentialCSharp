using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_38.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_FileAttributes_UseFlagsAttribute()
    {
        string expected = (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) || RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            ? @"原本输出""ReadOnly, Hidden""，替换为""ReadOnly | Hidden""。
ReadOnly, Hidden"
            : @"原本输出""ReadOnly""，替换为""ReadOnly""。
ReadOnly";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
    }
}
