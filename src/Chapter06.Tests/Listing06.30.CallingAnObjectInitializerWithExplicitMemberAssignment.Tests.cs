namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_30.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_ObjectInitializerSetTitleSalary_WriteEmployeeWithTitleSalary()
    {
        const string expected =
            @"Inigo Montoya (电脑发烧友): 不够";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
