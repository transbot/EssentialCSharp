namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_09;

using System.Diagnostics;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string[] languages = new [] {
            "C#", "COBOL", "Java",
            "C++", "TypeScript", "Python",};

        // 用数组的前三个元素创建一个Span<string>，这是一个“切片”
        Span<string> languageSpan = languages.AsSpan(0, 2);
        languages[0] = "R";
        Assert(languages[0] == languageSpan[0]);
        Assert("R" == languageSpan[0]);
        languageSpan[0] = "Lisp";
        Assert(languages[0] == languageSpan[0]);
        Assert("Lisp" == languages[0]);

        int[] numbers = languages.Select(item => item.Length).ToArray();
        // 用数组的前三个元素创建一个Span<int>
        Span<int> numbersSpan = numbers.AsSpan(0, 2);
        Assert(numbers[1] == numbersSpan[1]);
        numbersSpan[1] = 42;
        Assert(numbers[1] == numbersSpan[1]);
        Assert(42 == numbers[1]);
        
        const string bigWord = "supercalifragilisticexpialidocious";
        // 用单词的一个后缀部分创建一个Span<char>
        #if NET8_0_OR_GREATER
        ReadOnlySpan<char> expialidocious = bigWord.AsSpan(20..);
        #else // NET8_0_OR_GREATER
        ReadOnlySpan<char> expialidocious = bigWord.AsSpan(20, 14);
        #endif // NET8_0_OR_GREATER
        Assert(expialidocious.ToString() == "expialidocious");
#endregion INCLUDE
    }
    
    static void Assert(bool condition, 
        [CallerArgumentExpression(nameof(condition))]string expression = null!)
    {
        if (!condition)
        {
            throw new Exception($"Assertion(断言)失败: {expression}");
        }
    }
}
