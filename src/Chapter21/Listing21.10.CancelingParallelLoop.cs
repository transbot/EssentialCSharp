namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_10;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public static class Program
{
    public static List<string> ParallelEncrypt(
        List<string> data,
        CancellationToken cancellationToken)
    {
        int governor = 0;
        return data.AsParallel().WithCancellation(
            cancellationToken).Select(
                (item) =>
                {
                    if (Interlocked.CompareExchange(
                        ref governor, 0, 100) % 100 == 0)
                    {
                        Console.Write('.');
                    }
                    Interlocked.Increment(ref governor);
                    return Encrypt(item);
                }).ToList();
    }

    public static async Task Main()
    {
        ConsoleColor originalColor = Console.ForegroundColor;
        List<string> data = Utility.GetData(100000).ToList();

        using CancellationTokenSource cts = new();

        Task task = Task.Run(() =>
        {
            data = ParallelEncrypt(data, cts.Token);
        }, cts.Token);

        Console.WriteLine("按Enter键退出。");
        Task<int> cancelTask = ConsoleReadAsync(cts.Token);

        try
        {
            Task.WaitAny(task, cancelTask);
            // 两个任务中的任何一个完成，
            // 程序就尝试取消另一个尚未完成的任务。            
            cts.Cancel();
            await task;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n成功完成");
        }
        catch (OperationCanceledException taskCanceledException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(
                $"\n已取消: { taskCanceledException.Message }");
        }
        finally
        {
            Console.ForegroundColor = originalColor;
        }
    }

    private static async Task<int> ConsoleReadAsync(
        CancellationToken cancellationToken = default)
    {
        return await Task.Run(async () =>
        {
            const int maxDelay = 1025;
            int delay = 0;
            while (!cancellationToken.IsCancellationRequested)
            {
                if (Console.KeyAvailable)
                {
                    return Console.Read();
                }
                else
                {
                    await Task.Delay(delay, cancellationToken);
                    if (delay < maxDelay) delay *= 2 + 1;
                }
            }
            cancellationToken.ThrowIfCancellationRequested();
            throw new InvalidOperationException(
                "上一行代码就应该已经抛出异常了，所以这一行应该永远执行不到");
        }, cancellationToken);
    }

    private static string Encrypt(string item)
    {
        Cryptographer cryptographer = new();
        return System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
    }
}
#endregion INCLUDE