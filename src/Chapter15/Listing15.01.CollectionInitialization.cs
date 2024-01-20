namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_01;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<string> sevenWorldBlunders;
        sevenWorldBlunders = new List<string>()
        {
            // 所谓“甘地的名言”（世界七大错）
            "没有辛劳的财富",
            "没有良心的享乐",
            "没有品格的知识",
            "没有道德的商业",
            "没有人性的科学",
            "没有牺牲的崇拜",
            "没有原则的政治"            
        };

        Print(sevenWorldBlunders);
    }

    private static void Print<T>(IEnumerable<T> items)
    {
        foreach(T item in items)
        {
            Console.WriteLine(item);
        }
    }
}
#endregion INCLUDE
