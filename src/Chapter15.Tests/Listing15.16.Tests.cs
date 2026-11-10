
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_16.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"1. Patents prior to the 1900s are:
	留声机 (1877)
	活动电影机 (1888)
	电报 (1837)
	蒸汽机车 (1815)

2. A second listing of patents prior to the 1900s:
	留声机 (1877)
	活动电影机 (1888)
	电报 (1837)
	蒸汽机车 (1815)
   There are 4 patents prior to 1900.

3. A third listing of patents prior to the 1900s:
	留声机 (1877)
	活动电影机 (1888)
	电报 (1837)
	蒸汽机车 (1815)
   There are 4 patents prior to 1900.";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}