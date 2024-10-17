namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_05;

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
        CountContextualKeywords();
    }
    #endregion EXCLUDE
    private static void CountContextualKeywords()
    {
        int delegateInvocations = 0;
        string func(string text)
        {
            delegateInvocations++;
            return text;
        }

        IEnumerable<string> selection =
            from keyword in CSharp.Keywords
            where keyword.Contains('*')
            select func(keyword);

        Console.WriteLine(
            $"1. delegateInvocations={delegateInvocations}");

        // 执行Count()，会为每个选定的项调用一次func
        Console.WriteLine(
            $"2. 上下文关键字数量={selection.Count()}");

        Console.WriteLine(
            $"3. delegateInvocations={delegateInvocations}");

        // 执行Count()，会为每个选定的项调用一次func
        Console.WriteLine(
            $"4. 上下文关键字数量={selection.Count()}");

        Console.WriteLine(
            $"5. delegateInvocations={delegateInvocations}");

        // 缓存这个值，使未来的计数不会触发查询的另一次调用
        List<string> selectionCache = selection.ToList();

        Console.WriteLine(
            $"6. delegateInvocations={delegateInvocations}");

        // 从缓存的集合中获取计数
        Console.WriteLine(
            $"7. selectionCache数量={selectionCache.Count}");

        Console.WriteLine(
            $"8. delegateInvocations={delegateInvocations}");
    }
    //...
    #endregion INCLUDE
}

//namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_05;

//using AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16;
//#region INCLUDE
//using System;
//using System.Collections.Generic;
//using System.Linq;
//#region EXCLUDE
//public class Program
//{
//    public static void Main()
//    {
//        CountContextualKeywords();
//    }
//    #endregion EXCLUDE
//    private static void CountContextualKeywords()
//    {
//        int delegateInvocations = 0;
//        string func(string text)
//        {
//            delegateInvocations++;
//            return text;
//        }

//        IEnumerable<string> selection =
//            from keyword in CSharp.Keywords
//            where keyword.Contains('*')
//            select func(keyword);


//        Console.WriteLine(
//            $"1. delegateInvocations={ delegateInvocations }");

//        // Executing count should invoke func once for 
//        // each item selected
//        Console.WriteLine(
//            $"2. Contextual keyword count={ selection.Count() }");

//        Console.WriteLine(
//            $"3. delegateInvocations={ delegateInvocations }");

//        // Executing count should invoke func once for 
//        // each item selected
//        Console.WriteLine(
//            $"4. 上下文关键字计数={ selection.Count() }");

//        Console.WriteLine(
//            $"5. delegateInvocations={ delegateInvocations }");

//        // Cache the value so future counts will not trigger
//        // another invocation of the query
//        List<string> selectionCache = selection.ToList();

//        Console.WriteLine(
//            $"6. delegateInvocations={ delegateInvocations }");

//        // Retrieve the count from the cached collection
//        Console.WriteLine(
//            $"7. selectionCache count={ selectionCache.Count }");

//        Console.WriteLine(
//            $"8. delegateInvocations={ delegateInvocations }");
//    }
//    //...
//    #endregion INCLUDE
//}
