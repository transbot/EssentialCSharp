namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_09;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class AsyncSynchronizationContext : SynchronizationContext
{
    public Exception? Exception { get; set; }
    public ManualResetEventSlim ResetEvent { get; } = new();

    public override void Send(SendOrPostCallback callback, object? state)
    {
        try
        {
            Console.WriteLine($@"Send notification invoked...(Thread ID: {
                Thread.CurrentThread.ManagedThreadId})");
            callback(state);
        }
        catch (Exception exception)
        {
            Exception = exception;
        }
        finally
        {
            ResetEvent.Set();
        }
    }

    public override void Post(SendOrPostCallback callback, object? state)
    {
        try
        {
            Console.WriteLine($@"已调用Post通知...(线程ID: {
                Thread.CurrentThread.ManagedThreadId})");
            callback(state);
        }
        catch (Exception exception)
        {
            Exception = exception;
        }
        finally
        {
            ResetEvent.Set();
        }
    }
}

public static class Program
{
    public static bool EventTriggered { get; set; }

    public const string ExpectedExceptionMessage = "预期的异常";

    public static void Main()
    {
        SynchronizationContext? originalSynchronizationContext =
            SynchronizationContext.Current;
        try
        {
            AsyncSynchronizationContext synchronizationContext = new();
            SynchronizationContext.SetSynchronizationContext(
                synchronizationContext);

            OnEvent(typeof(Program), EventArgs.Empty);

            synchronizationContext.ResetEvent.Wait();

            if (synchronizationContext.Exception is not null)
            {
                Console.WriteLine($@"正在抛出预期的异常....(线程ID: {
                    Thread.CurrentThread.ManagedThreadId})");
                System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(
                    synchronizationContext.Exception).Throw();
            }
        }
        catch (Exception exception)
        {
            Console.WriteLine($@"已抛出预期的异常{exception}。(线程ID: {
                Thread.CurrentThread.ManagedThreadId})");
        }
        finally
        {
            SynchronizationContext.SetSynchronizationContext(
                originalSynchronizationContext);
        }
    }

    private static async void OnEvent(object sender, EventArgs eventArgs)
    {
        Console.WriteLine($@"正在调用Task.Run...(线程ID: {
                Thread.CurrentThread.ManagedThreadId})");
        await Task.Run(() =>
        {
            EventTriggered = true;
            Console.WriteLine($@"正在运行任务... (线程ID: {
                Thread.CurrentThread.ManagedThreadId})");
            throw new Exception(ExpectedExceptionMessage);
        });
    }
}
#endregion INCLUDE
