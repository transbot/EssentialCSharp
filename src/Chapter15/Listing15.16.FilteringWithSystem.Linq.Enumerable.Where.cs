namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_16;

using AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15;
#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
#region EXCLUDE

public class Program
{
    public static void Main()
    {
        #endregion EXCLUDE
        IEnumerable<Patent> patents = PatentData.Patents;
        bool result;
        patents = patents.Where(
            patent =>
            {
                if(result =
                    patent.YearOfPublication.StartsWith("18"))
                {
                    // 谓词应该只做判断，尽量避免下面这样在谓词中的副作用
                    Console.WriteLine("\t" + patent);
                }
                return result;
            });

        Console.WriteLine("1. 20世纪之前的专利清单之一:");
        foreach(Patent patent in patents)
        {
        }

        Console.WriteLine();
        Console.WriteLine(
            "2. 20世纪之前的专利清单之二:");
        Console.WriteLine(
            $@"   20世纪之前总共有{ patents.Count()
                }个专利。");


        Console.WriteLine();
        Console.WriteLine(
            "3. 18世纪之前的专利清单之三:");
        patents = patents.ToArray();
        Console.Write("   20世纪之前总共有");
        Console.WriteLine(
            $"{ patents.Count() }个专利。");

        //...
        #endregion INCLUDE
    }
}
