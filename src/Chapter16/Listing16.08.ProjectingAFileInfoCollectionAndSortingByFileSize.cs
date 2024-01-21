namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_08;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        ListByFileSize2(Directory.GetCurrentDirectory(), "*");
    }
    #endregion EXCLUDE
    public static void ListByFileSize2(
        string rootDirectory, string searchPattern)
    {
        IEnumerable<FileInfo> files =
            from fileName in Directory.EnumerateFiles(
                rootDirectory, searchPattern)
                #region HIGHLIGHT
            orderby new FileInfo(fileName).Length, fileName
            select new FileInfo(fileName);
        #endregion HIGHLIGHT

        foreach (FileInfo file in files)
        {
            //  为了简化，假定当前目录是根目录下的一个子目录 
            // （译注：其实就是为了避免判断是否要先显示一个点号）
            string relativePath = file.FullName.Substring(
                Directory.GetCurrentDirectory().Length);
            Console.WriteLine(
                $".{ relativePath }({ file.Length })");
        }
    }
    //...
    #endregion INCLUDE
}
