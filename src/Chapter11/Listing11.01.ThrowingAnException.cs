namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter11.Listing11_01;

using System;

#region INCLUDE
public sealed class TextNumberParser
{
    public static int Parse(string textDigit)
    {
        string[] digitTexts = 
            { "zero", "one", "two", "three", "four", 
              "five", "six", "seven", "eight", "nine" };

        int result = Array.IndexOf(
            digitTexts,
            // 利用C# 2.0的null合并操作符
            (textDigit ??
              // 利用C# 7.0的throw表达式
              throw new ArgumentNullException(nameof(textDigit))
            ).ToLower());

        if (result < 0)
        {
            // 利用C# 6.0的nameof操作符
            throw new ArgumentException(
                "传递的实参不是数位", nameof(textDigit));
        }
        return result;
    }
}
#endregion INCLUDE
