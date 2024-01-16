namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_37;

using System;
using Listing12_35;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        Console.WriteLine(
            MathEx.Max(7, 490)); // 没有提供类型实参
        Console.WriteLine(
            MathEx.Min("中国", "中国人"));
        #endregion INCLUDE
    }
}
