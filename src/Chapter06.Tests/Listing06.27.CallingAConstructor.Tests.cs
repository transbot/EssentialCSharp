
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_27.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_UsingAConstructor_WriteFirstNameLastNameSalary()
    {
        const string expected =
            @"Inigo Montoya: 太少了";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
