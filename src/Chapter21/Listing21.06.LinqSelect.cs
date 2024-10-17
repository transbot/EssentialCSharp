namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_06;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using System;
#region INCLUDE
using System.Collections.Generic;
using System.Linq;

public class Program
{
    // ...
    public static List<string>
      Encrypt(IEnumerable<string> data)
    {
        return data.Select(
            item => Encrypt(item)).ToList();
    }
    #region EXCLUDE
    private static string Encrypt(string item)
    {
        Console.WriteLine($">>>>>正在加密'{ item }'.");
        Cryptographer cryptographer = new();
        string itemEncrypted = System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
        Console.WriteLine($"<<<<<结束加密'{ itemEncrypted }'.");
        return itemEncrypted;
    }
    #endregion EXCLUDE
}
#endregion INCLUDE


