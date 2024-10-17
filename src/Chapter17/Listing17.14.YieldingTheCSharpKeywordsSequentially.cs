namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_14;

#region INCLUDE
using System;
using System.Collections.Generic;

public class CSharpBuiltInTypes : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        yield return "object";
        yield return "byte";
        yield return "uint";
        yield return "ulong";
        yield return "float";
        yield return "char";
        yield return "bool";
        yield return "ushort";
        yield return "decimal";
        yield return "int";
        yield return "sbyte";
        yield return "short";
        yield return "long";
        yield return "void";
        yield return "double";
        yield return "string";
    }

    // 还需要实现IEnumerable.GetEnumerator方法，因为
    // IEnumerable<T>是从IEnumerable派生的
    System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
    {
        // 直接调用上述IEnumerator<string> GetEnumerator()
        return GetEnumerator();
    }
}
public class Program
{
    public static void Main()
    {
        var keywords = new CSharpBuiltInTypes();
        foreach (string keyword in keywords)
        {
            Console.WriteLine(keyword);
        }
    }
}
#endregion INCLUDE
