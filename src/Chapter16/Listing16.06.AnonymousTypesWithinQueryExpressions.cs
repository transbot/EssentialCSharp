namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_06;

#region INCLUDE
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
#region EXCLUDE
public class Program
{
    public static void Main()
    {
        FindMonthOldFiles(Directory.GetCurrentDirectory(), "*");
    }
    #endregion EXCLUDE

    // 查找一个月前的文件
    public static void FindMonthOldFiles(
    string rootDirectory, string searchPattern)
    {
        IEnumerable<FileInfo> files =
            from fileName in Directory.EnumerateFiles(
                rootDirectory, searchPattern)
                #region HIGHLIGHT
            where File.GetLastWriteTime(fileName) <
                DateTime.Now.AddMonths(-1)
            #endregion HIGHLIGHT
            select new FileInfo(fileName);

        foreach(FileInfo file in files)
        {
            //  为了简化，假定当前目录是根目录下的一个子目录 
            // （译注：其实就是为了避免判断是否要先显示一个点号）
            string relativePath = file.FullName.Substring(
                Directory.GetCurrentDirectory().Length);
            Console.WriteLine(
                $".{ relativePath } ({ file.LastWriteTime })");
        }
    }
    //...
    #endregion INCLUDE
}
