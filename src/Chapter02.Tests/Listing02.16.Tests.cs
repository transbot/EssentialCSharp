using Microsoft.CodeAnalysis;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_16.Tests;

[TestClass]
public class NewLineInterpolationTests
{
    [TestMethod]
    public void Main_CorrectOutput()
    {
        string firstName = "Inigo";
        string lastName = "Montoya";

        string expected = @$"嘿，你！
请输入你的名字: <<{firstName}
>>请输入你的姓氏: <<{lastName}
>>你的全名是: {firstName} {lastName}。";


        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
              Program.Main);


    }
}
