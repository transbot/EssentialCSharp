using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_10;

using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        Angle angle = new(90, 0, 0, null);

         // with操作符等价于：
        // Angle copy = new(degrees, minutes, seconds);
        Angle copy = angle with { };
        Trace.Assert(angle == copy);

        // with操作符支持用对象初始化器形式的
        // 语法来实例化一个修改后的拷贝。
        Angle modifiedCopy = angle with { Degrees = 180 };
        Trace.Assert(angle != modifiedCopy);
        #endregion INCLUDE
    }
}
