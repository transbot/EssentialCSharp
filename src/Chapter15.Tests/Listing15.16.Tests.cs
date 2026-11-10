
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_16.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"1. 20世纪之前的专利清单之一:
	留声机 (1877)
	活动电影机 (1888)
	电报 (1837)
	蒸汽机车 (1815)

2. 20世纪之前的专利清单之二:
	留声机 (1877)
	活动电影机 (1888)
	电报 (1837)
	蒸汽机车 (1815)
   20世纪之前总共有4个专利。

3. 18世纪之前的专利清单之三:
	留声机 (1877)
	活动电影机 (1888)
	电报 (1837)
	蒸汽机车 (1815)
   20世纪之前总共有4个专利。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}