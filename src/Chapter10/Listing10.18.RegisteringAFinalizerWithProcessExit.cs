namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_18
{
    using System;
    #region INCLUDE
    using System.IO;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using static ConsoleLogger;

    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("开始...");
            DoStuff();
            if (args.Any(arg => arg.ToLower() == "-gc"))
            {
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            WriteLine("退出...");
        }

        public static void DoStuff()
        {
            // ...
            
            WriteLine("开始...");
            SampleUnmanagedResource? sampleUnmanagedResource = null;

            try
            {
                sampleUnmanagedResource =
                    new SampleUnmanagedResource();
                // 使用非托管资源
                // ...
            }
            finally
            {
                if (Environment.GetCommandLineArgs().Any(
                arg => arg.ToLower() == "-dispose"))
                {
                    sampleUnmanagedResource?.Dispose();
                }
            }

            WriteLine("退出...");

            // ...
        }
    }

    class SampleUnmanagedResource : IDisposable
    {
        public SampleUnmanagedResource(string fileName)
        {
            WriteLine("开始...",
                $"{nameof(SampleUnmanagedResource)}.ctor");

            WriteLine("创建托管资源...",
                $"{nameof(SampleUnmanagedResource)}.ctor");
            WriteLine("创建非托管资源...",
                $"{nameof(SampleUnmanagedResource)}.ctor");

            WeakReference<IDisposable> weakReferenceToSelf =
                 new(this);
            ProcessExitHandler = (_, __) =>
            {
                WriteLine("开始...", "ProcessExitHandler");
                if (weakReferenceToSelf.TryGetTarget(
                    out IDisposable? self))
                {
                    self.Dispose();
                }
                WriteLine("退出...", "ProcessExitHandler");
            };
            AppDomain.CurrentDomain.ProcessExit
                += ProcessExitHandler;
            WriteLine("退出...",
                $"{nameof(SampleUnmanagedResource)}.ctor");
        }

        // 将进程退出委托存储下来，以便在已经调用
        // Dispose() or Finalize()的前提下移除它
        private EventHandler ProcessExitHandler { get; }

        public SampleUnmanagedResource()
            : this(Path.GetTempFileName()) { }

        ~SampleUnmanagedResource()
        {
            WriteLine("开始...");
            Dispose(false);
            WriteLine("退出...");
        }

        public void Dispose()
        {
            Dispose(true);
            #region EXCLUDE
            // 请求不要为这个对象调用终结器
            GC.SuppressFinalize(this);
            #endregion EXCLUDE
        }

        public void Dispose(bool disposing)
        {
            WriteLine("开始...");

            // 设计规范：避免为自带终结器的对象调用Dispose()。相反，依赖终结队列清理实例。
            // 具体的解释是：调用Dispose方法时，如果disposing参数为false，
            // 那么表明它是由终结器调用的，而不是通过程序代码显式调用的。
            // 在这种情况下，应该只清理非托管资源（例如文件），因为垃圾收集器
            // 会自动处理托管资源。加了这个判断后，可以避免在终结器和Dispose
            // 方法之间发生资源重复清理的问题。
            // 总之，仅在disposing为true的时候才释放托管资源，而其他任何时候都
            // 只释放非托管资源，这才是Dispose模式的正确姿势。
            if (disposing)
            {
                WriteLine("正在dispose托管资源...");
            }

            AppDomain.CurrentDomain.ProcessExit -=
                ProcessExitHandler;

            WriteLine("正在dispose非托管资源...");

            WriteLine("退出...");
        }
    }
    #endregion INCLUDE

    public static class ConsoleLogger
    {
        public static void WriteLine(string? message = null, [CallerMemberName] string? name = null)
            => Console.WriteLine($"{$"{name}: " }{ message ?? ": 正在执行" }");
    }
}
