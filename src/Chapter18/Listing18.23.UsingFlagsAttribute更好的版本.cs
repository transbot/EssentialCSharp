using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "enumtest.txt";

        // 确保文件存在
        if (!File.Exists(filePath))
        {
            // 如果文件不存在，创建文件
            using (var stream = File.Create(filePath)) { }
            Console.WriteLine($"已创建{filePath}。");
        }

        var file = new FileInfo(filePath);

        try
        {
            // 获取初始文件属性
            FileAttributes startingAttributes = file.Attributes;
            Console.WriteLine($"初始文件属性: {startingAttributes}");

            // 设置文件属性为隐藏和只读
            file.Attributes = FileAttributes.Hidden | FileAttributes.ReadOnly;
            Console.WriteLine($"已将文件属性设为: {file.Attributes}");

            // 修改显示效果，将逗号改为竖线
            Console.WriteLine("原本输出\"{1}\"，替换为\"{0}\"。",
                file.Attributes.ToString().Replace(",", " |"),
                file.Attributes);
        }
        catch (IOException e)
        {
            Console.WriteLine($"发生I/O错误: {e.Message}");
        }

        // 删除文件前，必须先清除只读属性
        file.Attributes &= ~FileAttributes.ReadOnly;

        // 删除文件
        file.Delete();
        Console.WriteLine($"文件{filePath}已删除。");
    }
}
