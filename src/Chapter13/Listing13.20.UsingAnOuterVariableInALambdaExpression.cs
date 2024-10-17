namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_20;

using System;
using Listing13_11;
#region INCLUDE
public class Program
{
    public static void Main()
    {
        int[] items = new int[5];
        #region HIGHLIGHT
        int comparisonCount = 0;
        #endregion HIGHLIGHT

        for (int i = 0; i < items.Length; i++)
        {
            Console.Write("请输入一个整数: ");
            string? text = Console.ReadLine();
            if (!int.TryParse(text, out items[i]))
            {
                Console.WriteLine($"'{text}'不是一个有效的整数。");
                return;
            }
        }

        #region HIGHLIGHT
        DelegateSample.BubbleSort(items,
            (int first, int second) =>
            {
                comparisonCount++;
                return first < second;
            }
        );
        #endregion HIGHLIGHT

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }

        #region HIGHLIGHT
        Console.WriteLine("items被比较了{0}次。",
            comparisonCount);
        #endregion HIGHLIGHT
    }
}
#endregion INCLUDE
