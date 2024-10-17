namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_06;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        bool parentTaskFaulted = false;
        Task task = new(() =>
            {
                throw new InvalidOperationException();
            });
        #region HIGHLIGHT
        Task continuationTask = task.ContinueWith(
        #endregion HIGHLIGHT
            (antecedentTask) =>
            {
                parentTaskFaulted =
                    antecedentTask.IsFaulted;
            }, TaskContinuationOptions.OnlyOnFaulted);
        task.Start();
        #region HIGHLIGHT
        continuationTask.Wait();
        #endregion HIGHLIGHT
        if (!parentTaskFaulted)
        {
            throw new Exception("父任务出错了(faulted)");
        }
        if (!task.IsFaulted)
        {
            throw new Exception("任务出错了(faulted)");
        }

        #region HIGHLIGHT
        task.Exception!.Handle(eachException =>
        #endregion HIGHLIGHT
        {
            Console.WriteLine(
                $"错误: { eachException.Message }");
            return true;
        });
    }
}
#endregion INCLUDE
