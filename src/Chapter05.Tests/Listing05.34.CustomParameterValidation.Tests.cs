
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_34.Tests;

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

#if !NET7_0_OR_GREATER
[TestMethod]
    public void Main_NoArgs_ExpectFirstNullError()
    {
        string[] args = {null! , "Montoya"};
        string expected = "Value cannot be null. (Parameter \'httpsUrl\')";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }

    [TestMethod]
    public void Main_FirstArg_ExpectSecondNullError()
    {
        string[] args = { "Inigo", null! };
        string expected = "Value cannot be null. (Parameter \'fileName\')";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }

    [TestMethod]
    public void Main_InvalidSecondArg_ExpectWhitespaceError()
    {
        string[] args = { "Inigo", "  " };
        string expected = "fileName不能为空或者空串";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
#else
    [TestMethod]
    public void Main_NoArgs_ExpectFirstNullError()
    {
        string[] args = { null!, "Montoya" };
        string expected = "Value cannot be null. (Parameter \'httpsUrl = httpsUrl?.Trim()!\')";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }

    [TestMethod]
    public void Main_FirstArg_ExpectSecondNullError()
    {
        string[] args = { "Inigo", null! };
        string expected = "Value cannot be null. (Parameter \'fileName = fileName?.Trim()!\')";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }

    [TestMethod]
    public void Main_InvalidSecondArg_ExpectWhitespaceError()
    {
        string[] args = { "Inigo", "  " };
        string expected = "The value cannot be an empty string. (Parameter \'fileName = fileName?.Trim()!\')";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }
#endif

    [TestMethod]
    public void Main_InvalidSecondArg_ExpectHTTPError()
    {
        string[] args = { "Inigo", "Montoya" };
        string expected = "URL必须以\'HTTPS\'开头。";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            try
            {
                Program.Main(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });
    }

    [TestMethod]
    public void Main_IntelliTectIndexHtmlArgs_DownloadFile()
    {
        try
        {
            string fileName = "about";
            string[] args = { "https://IntelliTect.com", fileName };
            string expected = $"已从'{args[0]}'下载'{args[1]}'。";

            int? result = null;
            IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, () => result = Program.Main(args));
        }
        catch (AggregateException exception) when (exception.InnerException is System.Net.Http.HttpRequestException)
        {
            Assert.Inconclusive("Unable to download the file.  Check your internet connection.");
        }
    }
}
