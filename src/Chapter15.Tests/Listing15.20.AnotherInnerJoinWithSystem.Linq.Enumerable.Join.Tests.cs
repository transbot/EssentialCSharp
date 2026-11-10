
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_20.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void EnumerableJoinTest()
    {
        string expected =
@"Corporate
	Mark Michaelis (首席电脑发烧友)
人力资源
	Anne Beard (人力资源总监)
工程
	Michael Stokesbary (高级电脑巫师)
工程
	Brian Jones (企业集成大师)
工程
	Kevin Bost (杰出程序员)
工程
	Thomas Heavey (软件架构师)
IT
	Pat Dever (企业架构师)
慈善
	Eric Edmonds (慈善协调员)";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}
