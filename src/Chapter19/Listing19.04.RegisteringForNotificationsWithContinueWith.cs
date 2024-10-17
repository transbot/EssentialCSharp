namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_04;

#region INCLUDE
using System;
using System.Threading.Tasks;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;

public class Program
{
    public static void Main()
    {
        // .NET 4.5之前Task.Run()不可用，要改为使用
        // Task.Factory.StartNew<string>()        
        Task<string> task =
            Task.Run<string>(
                () => PiCalculator.Calculate(10));
        Task faultedTask = task.ContinueWith(
            (antecedentTask) =>
            {
                if(!antecedentTask.IsFaulted)
                {
                    throw new Exception("先行任务出错了(Faulted)");
                }
                Console.WriteLine(
                    "任务状态: Faulted");
            },
            TaskContinuationOptions.OnlyOnFaulted);

        Task canceledTask = task.ContinueWith(
            (antecedentTask) =>
            {
                if (!antecedentTask.IsCanceled)
                {
                    throw new Exception("先行任务取消了(Canceled)");
                }
                Console.WriteLine(
                    "任务状态: Canceled");
            },
            TaskContinuationOptions.OnlyOnCanceled);

        Task completedTask = task.ContinueWith(
            (antecedentTask) =>
            {
                if (!antecedentTask.IsCompleted)
                {
                    throw new Exception("先行任务完成了(Completed)");
                }
                Console.WriteLine(
                    "任务状态: Completed");
            }, TaskContinuationOptions.
                    OnlyOnRanToCompletion);

        completedTask.Wait();
    }
}
#endregion INCLUDE





