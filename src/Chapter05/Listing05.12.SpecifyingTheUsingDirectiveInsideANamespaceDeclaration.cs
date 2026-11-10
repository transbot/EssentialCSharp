// 中文版译稿代码清单5.12：在命名空间声明中使用 using 指令。
// HelloWorld 的 public 可见性和下方 Program 包装器用于配套清单运行器。
namespace EssentialCSharp
{
    #region INCLUDE
    using System;

    public class HelloWorld
    {
        public static void Main()
        {
            // 因为上方的 using 指令，所以不需要用 System 限定 Console 类。
            Console.WriteLine("你好，我的名字是Inigo Montoya。");
        }
    }
    #endregion INCLUDE
}

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_12
{
    public class Program
    {
        public static void Main() => global::EssentialCSharp.HelloWorld.Main();
    }
}
