namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_28;

using System;
public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int number;
        object thing;
        number = 42;
        // 装箱
        thing = number;
        #region HIGHLIGHT
        // 这里不会发生拆箱
        #endregion HIGHLIGHT
        string text = ((IFormattable)thing).ToString(
            "X", null);
        Console.WriteLine(text);
        #endregion INCLUDE
    }
}
