namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter20.Listing20_13;

#region INCLUDE
using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        DisplayStatus("开始之前");
        Task taskA =
            Task.Run(() =>
                 DisplayStatus("开始..."))
            .ContinueWith(antecedent =>
                 DisplayStatus("继续A..."));
        Task taskB = taskA.ContinueWith(antecedent =>
      DisplayStatus("继续B..."));
        Task taskC = taskA.ContinueWith(antecedent =>
            DisplayStatus("继续C..."));
        Task.WaitAll(taskB, taskC);
        DisplayStatus("结束!");
    }

    private static void DisplayStatus(string message)
    {
        string text = 
                $@"{ Thread.CurrentThread.ManagedThreadId 
                    }: { message }";


        Console.WriteLine(text);
    }
}
#endregion INCLUDE





