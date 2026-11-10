
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_16.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Main_NoArgs_ExpectErrors()
    {
        string[] args = Array.Empty<string>();
        string expected = """
            错误: 必须指定URL和文件名
            用法: Downloader.exe <URL> <文件名>
            """;

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main(args);
        });
    }

    [TestMethod]
    public void Main_IntelliTectIndexHtmlArgs_DownloadFile()
    {
        try
        {
            string fileName = "about";
            string[] args = { "http://IntelliTect.com", fileName };
            string expected = $"已从'{args[0]}'下载'{fileName}'。";

            int? result = null;
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => result = Program.Main(args));
        }
        catch (AggregateException exception) when (exception.InnerException is System.Net.Http.HttpRequestException)
        {
            Assert.Inconclusive("Unable to download the file.  Check your internet connection.");
        }
    }

    [TestMethod]
    public void Main_GoodArgs_DownloadFile()
    {
        string[] args = { "http://google.com", Path.Combine(Directory.GetCurrentDirectory(), "destination.txt") };

        try
        {
            Assert.AreEqual(0, Program.Main(args));
        }
        catch (AggregateException exception) when (exception.InnerException is System.Net.Http.HttpRequestException)
        {
            Assert.Inconclusive("Unable to download the file.  Check your Internet connection.");
        }
    }
}
