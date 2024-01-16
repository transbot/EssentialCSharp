namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_36;

using System;
using Listing12_35;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        Console.WriteLine(
            MathEx.Max<int>(7, 490));
        Console.WriteLine(
            MathEx.Min<string>("中国", "中国人"));
        #endregion INCLUDE
    }
}
