
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_10.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void FilteringWithSystem_Linq_Enumerable_Where()
    {
        string expected =
@"留声机 (1877)
活动电影机 (1888)
电报 (1837)
蒸汽机车 (1815)";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}
