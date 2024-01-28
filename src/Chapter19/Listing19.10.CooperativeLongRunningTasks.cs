namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_10;

using System;
using System.Threading;
using AddisonWesley.Michaelis.EssentialCSharp.Shared;
#region INCLUDE
using System.Threading.Tasks;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        string stars =
            "*".PadRight(Console.WindowWidth - 1, '*');
        Console.WriteLine("按Enter键退出。");

        CancellationTokenSource cancellationTokenSource = new();

        // .NET 4.5之前Task.Run()不可用，要改为使用
        // Task.Factory.StartNew<string>()
        #endregion EXCLUDE
        Task task = Task.Factory.StartNew(
            () => WritePi(cancellationTokenSource.Token),
        #region HIGHLIGHT
                    TaskCreationOptions.LongRunning);
        #endregion HIGHLIGHT

        //...
        #endregion INCLUDE

        // Wait for the user's input
        Console.ReadLine();

        cancellationTokenSource.Cancel();
        Console.WriteLine(stars);
        task.Wait();
        Console.WriteLine();
    }

    private static void WritePi(
        CancellationToken cancellationToken)
    {
        const int batchSize = 1;
        string piSection = string.Empty;
        int i = 0;

        while(!cancellationToken.IsCancellationRequested
            || i == int.MaxValue)
        {
            piSection = PiCalculator.Calculate(
                batchSize, (i++) * batchSize);
            Console.Write(piSection);
        }
    }
}

