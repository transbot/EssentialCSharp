namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_15;

using System;
using Listing12_14;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        Pair<int, string> historicalEvent =
            new(1914,
                "沙克尔顿乘坐“坚忍号”前往南极。");

        Console.WriteLine("{0}: {1}",
            historicalEvent.First, historicalEvent.Second);
        #endregion INCLUDE
    }
}
