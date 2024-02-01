namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter21.Listing21_08;

using AddisonWesley.Michaelis.EssentialCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // ...
    public static List<string>
      Encrypt(IEnumerable<string> data)
    {
        #region INCLUDE
        //...
        #region HIGHLIGHT
        OrderedParallelQuery<string> parallelGroups =
            data.AsParallel().OrderBy(item => item);
        #endregion HIGHLIGHT

        // 验证数据项的总计数仍与原始计数匹配
        if (data.Count() != parallelGroups.Sum(
                item => item.Length))
        {
            throw new Exception("data.Count() != parallelGroups" +
                ".Sum(item => item.Count()");
        }
        // ...
        #endregion INCLUDE

        return data.AsParallel().Select(
            item => Program.Encrypt(item)).ToList();
    }

    // ...

    private static string Encrypt(string item)
    {
        Console.WriteLine($">>>>>正在加密'{ item }'.");
        Cryptographer cryptographer = new();
        string itemEncrypted = System.Text.Encoding.UTF8.GetString(cryptographer.Encrypt(item));
        Console.WriteLine($"<<<<<结束加密'{ itemEncrypted }'.");
        return itemEncrypted;
    }

}


