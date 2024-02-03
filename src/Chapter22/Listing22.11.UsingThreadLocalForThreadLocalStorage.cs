namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_11;

#region INCLUDE
using System;
using System.Threading;

public class Program
{
    #region HIGHLIGHT
    static ThreadLocal<double> _Count = new(() => 0.01134);
    #endregion HIGHLIGHT
    public static double Count
    {
        get { return _Count.Value; }
        set { _Count.Value = value; }
    }

    public static void Main()
    {
        Thread thread = new(Decrement);
        thread.Start();

        // 递增
        for(double i = 0; i < short.MaxValue; i++)
        {
            Count++;
        }
        thread.Join();
        Console.WriteLine("Main中的Count = {0}", Count);
    }

    // 递减
    public static void Decrement()
    {
        Count = -Count;
        for(double i = 0; i < short.MaxValue; i++)
        {
            Count--;
        }
        Console.WriteLine(
            "Decrement中的Count = {0}", Count);
    }
}
#endregion INCLUDE
