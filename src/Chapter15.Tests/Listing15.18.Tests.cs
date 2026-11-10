
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_18.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"Corporate
人力资源
工程
IT
慈善
市场

Mark Michaelis (首席电脑发烧友)
Michael Stokesbary (高级电脑巫师)
Brian Jones (企业集成大师)
Anne Beard (人力资源总监)
Pat Dever (企业架构师)
Kevin Bost (杰出程序员)
Thomas Heavey (软件架构师)
Eric Edmonds (慈善协调员)";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}