namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_21;

using System;
using Listing13_11;
public class Program
{
    public static void Main()
    {
        int[] items = new int[5];

        for (int i = 0; i < items.Length; i++)
        {
            Console.Write("请输入一个整数:");
            string? text = Console.ReadLine();
            if (!int.TryParse(text, out items[i]))
            {
                Console.WriteLine($"'{text}'不是一个有效的整数。");
                return;
            }
        }

        #region INCLUDE
        int comparisonCount = 0;
        
        DelegateSample.BubbleSort(items,
        #region HIGHLIGHT
            static (int first, int second) =>
        #endregion HIGHLIGHT
            {
            #if COMPILEERROR // EXCLUDE
                // 错误 CS8820：静态匿名函数不能包含对comparisonCount的引用。
                comparisonCount++;
            #endif // COMPILEERROR // EXCLUDE
                return first < second;
            }
        );

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
