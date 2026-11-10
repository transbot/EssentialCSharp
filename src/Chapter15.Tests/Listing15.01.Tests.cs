
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_01.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"没有辛劳的财富
没有良心的享乐
没有品格的知识
没有道德的商业
没有人性的科学
没有牺牲的崇拜
没有原则的政治";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}