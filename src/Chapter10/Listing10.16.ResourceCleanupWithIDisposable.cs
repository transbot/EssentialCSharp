namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_16;

#region INCLUDE
using System;
using System.IO;

public static class Program
{
    // ...
    public static void Search()
    {
        TemporaryFileStream fileStream =
            new();

        // 使用临时文件流
        // ...

        #region HIGHLIGHT
        fileStream.Dispose();
        #endregion HIGHLIGHT

        // ...
    }
}

class TemporaryFileStream : IDisposable
{
    public TemporaryFileStream(string fileName)
    {
        File = new FileInfo(fileName);
        Stream = new FileStream(
            File.FullName, FileMode.OpenOrCreate,
            FileAccess.ReadWrite);
    }

    public TemporaryFileStream()
        : this(Path.GetTempFileName()) { }

    ~TemporaryFileStream()
    {
        #region HIGHLIGHT
        Dispose(false);
        #endregion HIGHLIGHT
    }

    public FileStream? Stream { get; private set; }
    public FileInfo? File { get; private set; }

    #region IDisposable Members
    #region HIGHLIGHT
    public void Dispose()
    {
        Dispose(true);

        // 取消向终结队列的登记（暂时不调用终结器）
        System.GC.SuppressFinalize(this);
    }
    #endregion HIGHLIGHT
    #endregion
    #region HIGHLIGHT
    public void Dispose(bool disposing)
    {
        // 设计规范：避免为自带终结器的对象调用Dispose()。相反，依赖终结队列清理实例。
        // 具体的解释是：调用Dispose方法时，如果disposing参数为false，
        // 那么表明它是由终结器调用的，而不是通过程序代码显式调用的。
        // 在这种情况下，应该只清理非托管资源（例如文件），因为垃圾收集器
        // 会自动处理托管资源。加了这个判断后，可以避免在终结器和Dispose
        // 方法之间发生资源重复清理的问题。
        // 总之，仅在disposing为true的时候才释放托管资源，而其他任何时候都
        // 只释放非托管资源，这才是Dispose模式的正确姿势。
        if (disposing)
        {
            Stream?.Dispose();
        }
    #endregion HIGHLIGHT
        try
        #region HIGHLIGHT
        {
            File?.Delete();
        }
        #endregion HIGHLIGHT
        catch (IOException exception)
        #region HIGHLIGHT
        {
            Console.WriteLine(exception);
        }
        #endregion HIGHLIGHT
        Stream = null;
        File = null;
    }
}
#endregion INCLUDE
