using System.Runtime.InteropServices;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_20.Tests;
#if NET8_0_OR_GREATER
[TestClass]
public class Listing21_20_Tests
{
    [TestMethod]
    public void GetProcessorIdReturnsCorrectValue()
    {
        string expected = @"Processor Id: *";
        if (!System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            expected = "本例只适用于Windows平台";
        }
        IntelliTect.TestTools.Console.ConsoleAssert.ExpectLike(expected,
            () =>
            {
                Program.Main();
            });
    }
}
#endif