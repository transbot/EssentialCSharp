namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_06;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Collections.Generic.Stack<int> stack =
            new();
        int number;
        System.Collections.Generic.Stack<int>.Enumerator
          enumerator;

        // ...

        // 如果显式实现IEnumerable<T，那么需要一次强制类型转换
        // ((IEnumerable<int>)stack).GetEnumerator();
        enumerator = stack.GetEnumerator();
        while(enumerator.MoveNext())
        {
            number = enumerator.Current;
            Console.WriteLine(number);
        }
        #endregion INCLUDE
    }
}
