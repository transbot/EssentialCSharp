
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_17.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"双焦点眼镜 (1784)
蒸汽机车 (1815)
电报 (1837)
留声机 (1877)
活动电影机 (1888)
飞机 (1903)
无背式胸罩 (1914)
液滴沉积装置 (1989)

液滴沉积装置 (1989)
无背式胸罩 (1914)
飞机 (1903)
活动电影机 (1888)
留声机 (1877)
电报 (1837)
蒸汽机车 (1815)
双焦点眼镜 (1784)";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}