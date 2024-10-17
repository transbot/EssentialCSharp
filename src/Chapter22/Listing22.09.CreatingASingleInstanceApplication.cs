namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_09;

#region INCLUDE
using System;
using System.Reflection;
using System.Threading;

public class Program
{
    public static void Main()
    {
        // 基于程序集全名来获得互斥体名称
        string mutexName =
            Assembly.GetEntryAssembly()!.FullName!;

        // firstApplicationInstance指出这是不是
        // 应用程序的第一个实例。
        using Mutex mutex = new(false, mutexName,
             out bool firstApplicationInstance);

        if (!firstApplicationInstance)
        {
            Console.WriteLine(
                "应用程序已经在运行了。");
        }
        else
        {
            Console.WriteLine("按Enter键关闭。");
            Console.ReadLine();
        }
    }
}
#endregion INCLUDE
