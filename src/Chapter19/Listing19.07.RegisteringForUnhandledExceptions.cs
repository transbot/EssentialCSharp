namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_07;

#region INCLUDE
using System;
using System.Diagnostics;
using System.Threading;

public class Program
{
    private static Stopwatch Clock { get; } = new Stopwatch();

    public static void Main()
    {
        try
        {
            Clock.Start();
            #region HIGHLIGHT
            // 注册一个回调，以便接收任何
            // 未处理异常的通知。
            AppDomain.CurrentDomain.UnhandledException +=
              (s, e) =>
              {
                  Message("正在启动事件处理程序.");
                  Delay(4000);
              };
            #endregion HIGHLIGHT
            Thread thread = new(() =>
            {
                Message("抛出异常。");
                throw new Exception();
            });
            thread.Start();
            
            Delay(2000);
        }
        finally
        {
            Message("正在运行finally块。");
        }
    }

    static void Delay(int i)
    {
        Message($"睡眠{i}毫秒");
        Thread.Sleep(i);
        Message("唤醒");
    }

    static void Message(string text)
    {
        Console.WriteLine("{0}:{1:0000}:{2}",
            Environment.CurrentManagedThreadId,
            Clock.ElapsedMilliseconds, text);
    }
}
#endregion INCLUDE
