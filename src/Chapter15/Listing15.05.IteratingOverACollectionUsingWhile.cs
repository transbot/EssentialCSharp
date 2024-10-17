namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_05;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        System.Collections.Generic.Stack<int> stack = new();
        int number;
        // ...

        // 概念性代码，非实际代码
        #if ConceptualCode
        while(stack.MoveNext())
        {   
            number = stack.Current();
            Console.WriteLine(number);
        }
        #endif // ConceptualCode

        #endregion INCLUDE

        // 实际代码
        while(stack.Pop() != -1) // 这实际并不是正确的逻辑，但重点在于while，而不在于栈
        {
            number = stack.Peek();
            Console.WriteLine(number);
        }
    }
}
