namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_04;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        ShowContextualKeywords2();
    }
    #endregion EXCLUDE
    private static void ShowContextualKeywords2()
    {
        IEnumerable<string> selection = from word in CSharp.Keywords
                                        where IsKeyword(word)
                                        select word;
        Console.WriteLine("已创建查询。");
        foreach(string keyword in selection)
        {
            // 这里不输出空格
            Console.Write(keyword);
        }
    }

    // 在谓词中包含了控制台输出的副作用；
    // 目的是演示推迟执行。但是，有副作用
    // 的谓词在生产代码中是一个不好的实践。
    private static bool IsKeyword(string word)
    {
        if(word.Contains('*'))
        {
            // 在这里输出空格
            Console.Write(" ");
            return true;
        }
        else
        {
            return false;
        }
    }
    //...
    #endregion INCLUDE
}