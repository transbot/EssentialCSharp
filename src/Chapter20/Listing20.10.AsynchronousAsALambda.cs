namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_10;

#region INCLUDE
using System;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;

public class Program
{

    public static void Main(string[] args)
    {
        string url = "http://www.IntelliTect.com";
        if(args.Length > 0)
        {
            url = args[0];
        }

        Console.Write(url);

        Func<string, Task> writeWebRequestSizeAsync =
        #region HIGHLIGHT
            async (string webRequestUrl) =>
            #endregion HIGHLIGHT
            {
                // 出于当前主题的目的省略了错误处理
                WebRequest webRequest =
                   WebRequest.Create(url);

                WebResponse response =
                #region HIGHLIGHT
                    await webRequest.GetResponseAsync();
                #endregion HIGHLIGHT

                // 显式计数而不是调用webRequest.ContentLength，
                // 以演示多个await操作符
                using (StreamReader reader =
                    new(response.GetResponseStream()))
                {
                    string text =
                    #region HIGHLIGHT
                        (await reader.ReadToEndAsync());
                    #endregion HIGHLIGHT
                    Console.WriteLine(
                        FormatBytes(text.Length));
                }
            };

        #region HIGHLIGHT
        Task task = writeWebRequestSizeAsync(url);
        #endregion HIGHLIGHT

        while (!task.Wait(100))
        {
            Console.Write(".");
        }
    }
    #region EXCLUDE
    public static string FormatBytes(long bytes)
    {
        string[] magnitudes =
            new [] { "GB", "MB", "KB", "字节" };
        long max =
            (long)Math.Pow(1024, magnitudes.Length);

        return string.Format("{1:##.##} {0}",
            magnitudes.FirstOrDefault(
                magnitude =>
                    bytes > (max /= 1024)) ?? "0字节",
                (decimal)bytes / (decimal)max).Trim();
    }
    #endregion EXCLUDE
}
#endregion INCLUDE





