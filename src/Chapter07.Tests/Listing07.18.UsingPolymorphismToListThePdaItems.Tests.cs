
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_18.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_WriteMultiplePdaItemToScreen()
    {
        DateTime startDateTime = new(2008, 7, 18);
        DateTime endDateTime = startDateTime.AddDays(1);

        string expected =
$@"________
名字: Sherlock
姓氏: Holmes
地址: 221B Baker Street, London, England

________
主题: Soccer tournament
开始时间: {startDateTime}
结束时间: {endDateTime}
地点: Estádio da Machava
________
名字: Anne
姓氏: Frank
地址: Apt 56B, Whitehaven Mansions, Sandhurst Sq, London" + Environment.NewLine + Environment.NewLine;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
            expected, Program.Main);
    }
}
