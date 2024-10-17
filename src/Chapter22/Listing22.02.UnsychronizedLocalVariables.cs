namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_02;

#region INCLUDE
using System;
using System.Threading.Tasks;

public class Program
{
    public static int Main(string[] args)
    {
        int total = int.MaxValue;
        if (args?.Length > 0) { _ = int.TryParse(args[0], out total); }
        Console.WriteLine("递增和递减" + $"{total}次...");
        int x = 0;

        // 并行for循环
        Parallel.For(0, total, i =>
        {
            x++;
            x--;
        });
        Console.WriteLine($"Count = {x}");
        return x;
    }
}
#endregion INCLUDE
