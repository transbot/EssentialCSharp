#region INCLUDE
#define CONDITION_A
#region EXCLUDE
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_24;

#endregion EXCLUDE
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("开始...");
        MethodA();
        MethodB();
        Console.WriteLine("结束...");
    }

    [Conditional("CONDITION_A")]
    public static void MethodA()
    {
        Console.WriteLine("MethodA()正在执行...");
    }

    [Conditional("CONDITION_B")]
    public static void MethodB()
    {
        Console.WriteLine("MethodB()正在执行...");
    }
}
#endregion INCLUDE
