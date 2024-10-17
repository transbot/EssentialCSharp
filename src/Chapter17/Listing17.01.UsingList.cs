namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_01;

#region INCLUDE
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // 七个小矮人
        List<string> list = new() { "Sneezy", "Happy", "Dopey",  "Doc",
                                    "Sleepy", "Bashful",  "Grumpy"};

        list.Sort();

        Console.WriteLine(
            $"按字母顺序，{ list[0] }是第一个小矮人，"
            + $"而{ list[^1] }是最后一个。");

        list.Remove("Grumpy");
    }
}
#endregion INCLUDE
