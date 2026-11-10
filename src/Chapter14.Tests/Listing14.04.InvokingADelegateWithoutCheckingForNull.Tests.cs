
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04.Tests;

using Listing14_04;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void InvokingDelegateWithoutCheckingForNull()
    {
        string expected = @"输入温度: <<1>>加热器: On
冷却器: Off";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}