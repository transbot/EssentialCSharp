
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_21.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        const string expected = @"
Mark Michaelis (首席电脑发烧友)
	计数: 1

Michael Stokesbary (高级电脑巫师)
Brian Jones (企业集成大师)
Kevin Bost (杰出程序员)
Thomas Heavey (软件架构师)
	计数: 4

Anne Beard (人力资源总监)
	计数: 1

Pat Dever (企业架构师)
	计数: 1

Eric Edmonds (慈善协调员)
	计数: 1";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}