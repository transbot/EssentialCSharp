
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_19.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void EnumerableJoinTest()
    {
        string expected =
@"Mark Michaelis (首席电脑发烧友)
	Corporate
Michael Stokesbary (高级电脑巫师)
	工程
Brian Jones (企业集成大师)
	工程
Anne Beard (人力资源总监)
	人力资源
Pat Dever (企业架构师)
	IT
Kevin Bost (杰出程序员)
	工程
Thomas Heavey (软件架构师)
	工程
Eric Edmonds (慈善协调员)
	慈善";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}
