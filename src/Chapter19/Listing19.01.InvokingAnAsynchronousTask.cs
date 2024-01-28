namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_01;

#region INCLUDE
using System;
#region HIGHLIGHT
using System.Threading.Tasks;
#endregion HIGHLIGHT

public class Program
{
    public static void Main()
    {
        const int repetitions = 10000;
        // .NET 4.5之前Task.Run()不可用，要改为使用
        // Task.Factory.StartNew<string>()
        Task task = Task.Run(() =>
            {
                for(int count = 0; count < repetitions; count++)
                {
                    Console.Write('-');
                }
            });
        for(int count = 0; count < repetitions; count++)
        {
            Console.Write('+');
        }

        // 等待任务完成
        task.Wait();
    }
}
#endregion INCLUDE
