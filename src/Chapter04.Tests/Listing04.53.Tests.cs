
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_53.Tests;

[TestClass]
public class EmailDomainTests
{
    [TestMethod]
    public void Main_EnterValidEmailWithDomain_WriteDomain()
    {
        const string expected =
@"输入一个电子邮件地址: <<First.Last@domain.com
>>该地址的域是: domain.com";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, EmailDomain.Main);
    }
    
    [TestMethod]
    public void Main_EnterInvalidEmailWithoutDomain_WriteBlank()
    {
        const string expected =
@"输入一个电子邮件地址: <<First.Last
>>该地址的域是: ";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, EmailDomain.Main);
    }
}
