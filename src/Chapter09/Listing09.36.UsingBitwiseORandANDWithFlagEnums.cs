namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_36;

#region INCLUDE
using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // ...

        string fileName = @".enumtest.txt";

        #region EXCLUDE
        System.IO.FileInfo enumFile = new(fileName);
        if (!enumFile.Exists)
        {
            enumFile.Create().Dispose();
        }

        try
        {
            #endregion EXCLUDE
            System.IO.FileInfo file = new(fileName)
            {
                Attributes = FileAttributes.Hidden |
                FileAttributes.ReadOnly
            };

            Console.WriteLine($"{file.Attributes} = {(int)file.Attributes}");

            // Linux上仅支持ReadOnly属性
            // (Hidden属性在Linux上不起作用)
            if (!file.Attributes.HasFlag(FileAttributes.Hidden))
            {
                throw new Exception("文件不是隐藏。");
            }
            
            if ((file.Attributes & FileAttributes.ReadOnly) !=
                FileAttributes.ReadOnly)
            {
                throw new Exception("文件不是只读。");
            }
        #region EXCLUDE
        }
        finally
        {
            if (enumFile.Exists)
            {
                enumFile.Attributes = FileAttributes.Normal;
                enumFile.Delete();
            }
        }
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
