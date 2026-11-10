
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_19.Tests;

[TestClass]
public class RawLiteralsWithInterpolationTests
{
    [TestMethod]
    public void Main_CorrectOutput()
    {
        const string firstName = "Inigo";
        const string lastName = "Montoya";

        const string expected = $@"请输入你的名字: <<{firstName}
>>请输入你的姓氏: <<{lastName}
>>你好，我叫{firstName}。{firstName} {lastName}。";

        string result = IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
             Program.Main);

    }
}
