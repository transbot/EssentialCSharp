namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_10;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    #region EXCLUDE
    // 说明 : 在Main开始时初始化
#pragma warning disable CS8618 // 不可为空的字段未初始化。考虑声明为可空。
    #endregion EXCLUDE
    static ManualResetEventSlim _MainSignaledResetEvent;
    static ManualResetEventSlim _DoWorkSignaledResetEvent;
    #region EXCLUDE
#pragma warning restore CS8618 // 不可为空的字段未初始化。考虑声明为可空。
    #endregion EXCLUDE

    public static void DoWork()
    {
        Console.WriteLine("DoWork()已启动....");
        #region HIGHLIGHT
        _DoWorkSignaledResetEvent.Set();
        _MainSignaledResetEvent.Wait();
        #endregion HIGHLIGHT
        Console.WriteLine("DoWork()正在结束....");
    }

    public static void Main()
    {
        using(_MainSignaledResetEvent = new ())
        using(_DoWorkSignaledResetEvent = new ())
        {
            Console.WriteLine(
                "应用程序已启动...");
            Console.WriteLine("正在启动任务...");

            // .NET 4.0要改为使用Task.Factory.StartNew
            Task task = Task.Run(() => DoWork());

            // 阻塞，直到DoWork()启动
            _DoWorkSignaledResetEvent.Wait();
            Console.WriteLine(
                "在线程执行期间等待...");
            _MainSignaledResetEvent.Set();
            task.Wait();
            Console.WriteLine("线程已结束");
            Console.WriteLine(
                "应用程序关闭...");
        }
    }
}
#endregion INCLUDE
