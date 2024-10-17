namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_25;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        IEnumerable<object> stuff =
            new object[] { new(), 1, 3, 5, 7, 9,
                "\"东西\"", Guid.NewGuid() };
        Print("杂物: {0}", stuff);

        IEnumerable<int> even = new int[] { 0, 2, 4, 6, 8 };
        Print("偶数: {0}", even);

        #region HIGHLIGHT
        IEnumerable<int> odd = stuff.OfType<int>();
        #endregion HIGHLIGHT
        Print("奇数: {0}", odd);

        #region HIGHLIGHT
        IEnumerable<int> numbers = even.Union(odd);
        #endregion HIGHLIGHT
        Print("奇数和偶数的并集: {0}", numbers);

        #region HIGHLIGHT
        Print("与偶数的并集: {0}", numbers.Union(even));
        Print("与奇数合并成超集: {0}", numbers.Concat(odd));
        #endregion HIGHLIGHT
        Print("与偶数的交集: {0}",
        #region HIGHLIGHT
            numbers.Intersect(even));
        Print("去重: {0}", numbers.Concat(odd).Distinct());
        #endregion HIGHLIGHT

        #region HIGHLIGHT
        if (!numbers.SequenceEqual(
            numbers.Concat(odd).Distinct()))
        #endregion HIGHLIGHT
        {
            throw new Exception("Unexpectedly unequal");
        }
        else
        {
            Console.WriteLine(
                @"Collection ""SequenceEquals""" +
                $" {nameof(numbers)}.Concat(odd).Distinct())");
        }
        #region HIGHLIGHT
        Print("反转: {0}", numbers.Reverse());
        Print("平均: {0}", numbers.Average());
        Print("总和: {0}", numbers.Sum());
        Print("最大: {0}", numbers.Max());
        Print("最小: {0}", numbers.Min());
        #endregion HIGHLIGHT
    }

    private static void Print<T>(
            string format, IEnumerable<T> items)
            where T : notnull =>
        Console.WriteLine(format, string.Join(
            ", ", items));
    #region EXCLUDE

    private static void Print<T>(string format, T item)
    {
        Console.WriteLine(format, item);
    }
    #endregion EXCLUDE
}
#endregion INCLUDE
