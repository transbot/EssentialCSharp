namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_07;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Collections.Generic.Stack<int> stack = new();
        System.Collections.Generic.Stack<int>.Enumerator enumerator;
        IDisposable disposable;

        enumerator = stack.GetEnumerator();
        try
        {
            int number;
            while (enumerator.MoveNext())
            {
                number = enumerator.Current;
                Console.WriteLine(number);
            }
        }
        finally
        {
            // 枚举器需要显式转型为IDisposable
            disposable = (IDisposable)enumerator;
            disposable.Dispose();

            // 除非编译时已知支持IDisposable，否则应该使用
            // as操作符将枚举器转型为IDisposable
            // disposable = (enumerator as IDisposable);
            // if (disposable is not null)
            // {
            //     disposable.Dispose();
            // }
        }
        #endregion INCLUDE
    }
}
