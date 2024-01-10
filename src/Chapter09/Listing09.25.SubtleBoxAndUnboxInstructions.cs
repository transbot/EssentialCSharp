namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_25;

using System;
#region INCLUDE
public class DisplayFibonacci
{
    public static void Main()
    {
        // 故意使用ArrayList来演示装箱
        System.Collections.ArrayList list = new();

        Console.Write("输入2～1000的整数，我将生成这么多个斐波那契数: ");
        string? inputText = Console.ReadLine();
        if (!int.TryParse(inputText, out int totalCount))
        {
            Console.WriteLine($"'{inputText}'不是一个有效的整数。");
            return;
        }

        if (totalCount == 7)  // 用一个魔法数字来执行测试
        {
            // 如果获取的值是double，那么会触发异常
            list.Add(0);  // 要求转型为double，或者附加'D'后缀。
                          // 无论转型还是使用'D'后缀，生成的CIL都是一样的。

        }
        else
        {
            list.Add((double)0);
        }

        list.Add((double)1);
        
        for(int count = 2; count < totalCount; count++)
        {
            list.Add(
                (double)list[count - 1]! +
                (double)list[count - 2]!);
        }

        // 用foreach来澄清装箱操作，而不是使用：
        // Console.WriteLine(string.Join(", ", list.ToArray()));
        foreach (double? count in list)
        {
            Console.Write($"{count}, ");
        }
    }
}
#endregion INCLUDE
