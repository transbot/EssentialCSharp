
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12.Tests;

[TestClass]
public class ProgramTests
{

    [TestMethod]
    public void Main_UsingToAvoidFullyQualifying_MethodCalledAsExpected()
    {
        const string expected = @"输入你的全名：(例如Inigo T. Montoya): <<Inigo T. Montoya
>>FirstName: Inigo
Initial: T
LastName: Montoya";
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected, Program.Main);
    }
}
