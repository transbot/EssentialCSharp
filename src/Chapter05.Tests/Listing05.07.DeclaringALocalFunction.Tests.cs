
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_07.Tests;

[TestClass]
public class HeyYouTests
{
    [TestMethod]
    public void Main_Tests()
    {
        const string expected =
@"名字: <<Inigo
>>姓氏: <<Montoya
>>电子邮件地址: <<imontoya@IntelliTect.com
>>Inigo Montoya <imontoya@IntelliTect.com>";
        
        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
