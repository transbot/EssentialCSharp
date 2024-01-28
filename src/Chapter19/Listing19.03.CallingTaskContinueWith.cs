namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_03;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("开始之前");
        // .NET 4.5之前Task.Run()不可用，要改为使用
        // Task.Factory.StartNew<string>()
        Task taskA =
            Task.Run(() =>
                 Console.WriteLine("开始..."))
            .ContinueWith(antecedent =>
                 Console.WriteLine("继续A..."));
        Task taskB = taskA.ContinueWith(antecedent =>
            Console.WriteLine("继续B..."));
        Task taskC = taskA.ContinueWith(antecedent =>
            Console.WriteLine("继续C..."));
        Task.WaitAll(taskB, taskC);
        Console.WriteLine("结束!");
    }
}
#endregion INCLUDE
