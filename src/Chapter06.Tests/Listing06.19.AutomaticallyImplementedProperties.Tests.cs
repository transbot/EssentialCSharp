
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_19.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_AutoPropertySetterGetter_WriteGetterValue()
    {
        const string expected =
@"Inigo
电脑发烧友";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
