
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_03.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void ObservingUnhandledExceptionsWithContinueWith()
    {
        string expected = @"开始之前
开始...
继续A...
继续{0}...
继续{1}...
结束!";
        string actual = IntelliTect.TestTools.Console.ConsoleAssert.Execute(expected,
        () =>
        {
            Program.Main();
        });

        Assert.IsTrue( 
            (string.Format(expected, 'B', 'C') == actual.TrimEnd()) || 
            (string.Format(expected, 'C', 'B') == actual.TrimEnd())
            );
    }
}