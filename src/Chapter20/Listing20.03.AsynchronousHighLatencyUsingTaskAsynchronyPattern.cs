namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_03;

#region INCLUDE
using System;
using System.IO;
using System.Threading.Tasks;

public static class Program
{
    public static HttpClient HttpClient { get; set; } = new();
    public const string DefaultUrl = "https://bookzhou.com";

    public static async Task Main(string[] args)
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

        Task<byte[]> taskDownload =
            HttpClient.GetByteArrayAsync(url);

        Console.Write("正在下载...");
        while (!taskDownload.Wait(100))
        {
            Console.Write(".");
        }

        byte[] downloadData = await taskDownload;

        Task<int> taskSearch = CountOccurrencesAsync(
            downloadData, findText);

        Console.Write($"{Environment.NewLine}正在搜索...");

        while (!taskSearch.Wait(100))
        {
            Console.Write(".");
        }

        int textOccurrenceCount = await taskSearch;

        Console.WriteLine(
            @$"{Environment.NewLine}'{findText}'在网址'{
                url}'出现了{textOccurrenceCount}次。");        
    }


    private static async Task<int> CountOccurrencesAsync(
        byte[] downloadData, string findText)
    {
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
    }
}
#endregion INCLUDE
