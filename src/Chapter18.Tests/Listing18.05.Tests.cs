
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_05.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WithNoParameters_DisplaysHelp()
    {
        string expected = @"System.Nullable<>是否包含泛型参数：True
System.Nullable<>是否泛型类型：True
System.Nullable<DateTime>是否包含泛型参数：False
System.Nullable<DateTime>是否泛型类型：True";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}