
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_09.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"双焦点眼镜 (1784)
留声机 (1877)
活动电影机 (1888)
电报 (1837)
飞机 (1903)
蒸汽机车 (1815)
液滴沉积装置 (1989)
无背式胸罩 (1914)

本杰明·富兰克林 (费城, PA)
奥维尔·莱特 (基蒂霍克, NC)
威尔伯·莱特 (基蒂霍克, NC)
塞缪尔·莫尔斯 (纽约, NY)
乔治·斯蒂芬森 (怀拉姆, 诺森伯兰)
约翰·迈克利斯 (芝加哥, IL)
玛丽·菲尔普斯·雅各布 (纽约, NY)";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}