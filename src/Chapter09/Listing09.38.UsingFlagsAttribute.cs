namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_38;

#region INCLUDE
// FileAttributes在System.IO中定义

using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        string fileName = @"enumtest.txt";
        #region EXCLUDE
        // 先做一些清理工作，以防因为文件处于只读状态而无法创建
        if (File.Exists(fileName))
        {
            FileAttributes attrs = File.GetAttributes(fileName);
            if (attrs.HasFlag(FileAttributes.ReadOnly))
                File.SetAttributes(fileName, attrs & ~FileAttributes.ReadOnly);
        }
        #endregion EXCLUDE
        FileInfo file = new(fileName);
        file.Open(FileMode.OpenOrCreate).Dispose();

        FileAttributes startingAttributes =
            file.Attributes;

        file.Attributes = FileAttributes.Hidden |
            FileAttributes.ReadOnly;

        Console.WriteLine("\"{0}\"，输出为\"{1}\"",
            file.Attributes.ToString().Replace(",", " |"),
            file.Attributes);

        FileAttributes attributes =
            (FileAttributes)Enum.Parse(typeof(FileAttributes),
            file.Attributes.ToString());

        Console.WriteLine(attributes);

        File.SetAttributes(fileName,
            startingAttributes);
        file.Delete();
    }
}
#endregion INCLUDE
