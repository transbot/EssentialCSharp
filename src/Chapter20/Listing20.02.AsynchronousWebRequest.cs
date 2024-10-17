namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_02;

#region INCLUDE
using System;
using System.IO;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

public static class Program
{
    public static HttpClient HttpClient { get; set; } = new();
    public const string DefaultUrl = "https://bookzhou.com";

    public static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("错误：没有输入要搜索的文本。");
            return;
        }
        string findText = args[0];

        string url = DefaultUrl;
        if (args.Length > 1)
        {
            url = args[1];
            // 最多取两个命令行参数，忽略更多的命令行参数
        }
        Console.WriteLine(
            $"从网址'{url}'搜索'{findText}'。");

        Console.WriteLine("正在下载...");
        Task task = HttpClient.GetByteArrayAsync(url)
            .ContinueWith(antecedent =>
            {
                byte[] downloadData = antecedent.Result;
                Console.Write($"{Environment.NewLine}正在搜索...");
                return CountOccurrencesAsync(
                    downloadData, findText);
            })
            .Unwrap()
            .ContinueWith(antecedent =>
            {
                int textOccurrenceCount = antecedent.Result;
                Console.WriteLine(
                     @$"{Environment.NewLine}'{findText}'在网址'{url}'出现了{
                        textOccurrenceCount}次。");

            });

        try
        {
            while (!task.Wait(100))
            {
                Console.Write(".");
            }
        }
        catch (AggregateException exception)
        {
            exception = exception.Flatten();
            try
            {
                exception.Handle(innerException =>
                {
                    // 重新抛出，而不是使用if条件来判断类型
                    ExceptionDispatchInfo.Capture(
                        innerException)
                        .Throw();
                    return true;
                });
            }
            catch (HttpRequestException)
            {
                #region EXCLUDE
                throw;
                #endregion EXCLUDE
            }
            catch (IOException)
            {
                #region EXCLUDE
                throw;
                #endregion EXCLUDE
            }
        }
    }


    private static async Task<int> CountOccurrencesAsync(
        byte[] downloadData, string findText)
    {
        #region EXCLUDE
        int textOccurrenceCount = 0;

        using MemoryStream stream = new(downloadData);
        using StreamReader reader = new(stream);

        int findIndex = 0;
        int length = 0;
        do
        {
            char[] data = new char[reader.BaseStream.Length];
            length = await reader.ReadAsync(data);
            for (int i = 0; i < length; i++)
            {
                if (findText[findIndex] == data[i])
                {
                    findIndex++;
                    if (findIndex == findText.Length)
                    {
                        // 找到了要搜索的文本
                        textOccurrenceCount++;
                        findIndex = 0;
                    }
                }
                else
                {
                    findIndex = 0;
                }
            }
        }
        while (length != 0);

        return textOccurrenceCount;
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
