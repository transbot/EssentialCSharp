
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_10.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_InputInigoMontoya_WriteFullName()
    {
        string view = """
            请输入你的名字: <<Inigo
            >>
            请输入你的中间名首字母: <<T.
            >>
            请输入你的姓氏: <<Montoya
            >>
            你好，Inigo T. Montoya！
            """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(view,
            Program.Main);
    }
}
