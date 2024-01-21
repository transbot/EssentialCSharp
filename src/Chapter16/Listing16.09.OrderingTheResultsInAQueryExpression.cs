namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_09;

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public class Program
{
    public static void Main()
    {
        ListByFileSize3(Directory.GetCurrentDirectory(), "*");
    }

    static void ListByFileSize3(
        string rootDirectory, string searchPattern)
    {
        #region INCLUDE
        //...
        IEnumerable<FileInfo> files =
            from fileName in Directory.EnumerateFiles(
                rootDirectory, searchPattern)
                #region HIGHLIGHT
            let file = new FileInfo(fileName)
            orderby file.Length, fileName
            select file;
        #endregion HIGHLIGHT
        //...
        #endregion INCLUDE


        foreach (FileInfo file in files)
        {
            //  为了简化，假定当前目录是根目录下的一个子目录 
            // （译注：其实就是为了避免判断是否要先显示一个点号）
            string relativePath = file.FullName.Substring(
                Directory.GetCurrentDirectory().Length);
            Console.WriteLine( 
                $".{ relativePath }({ file.Length })" );
        }
    }
}
