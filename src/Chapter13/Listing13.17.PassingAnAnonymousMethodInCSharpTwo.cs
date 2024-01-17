namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_17;

using System;
using Listing13_11;
public class Program
{
    public static void Main()
    {
        int[] items = new int[5];

        for(int i = 0; i < items.Length; i++)
        {
            Console.Write("请输入一个整数: ");
            string? text = Console.ReadLine();
            if (!int.TryParse(text, out items[i]))
            {
                Console.WriteLine($"'{text}'不是一个有效的整数。");
                return;
            }
        }
        #region INCLUDE
        //...
        DelegateSample.BubbleSort(items,
            delegate(int first, int second)
            {
                return first < second;
            }
        );
        //...
        #endregion INCLUDE

        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine(items[i]);
        }
    }
}