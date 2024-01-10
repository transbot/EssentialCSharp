using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_03;

#region INCLUDE
using System.Diagnostics;

public class Program
{
    public static void Main()
    {
        (int degrees, int minutes, int seconds) = (90, 0, 0);

        // 构造函数根据位置参数来生成
        Angle angle = new(degrees, minutes, seconds);

        // 记录包含一个ToString()实现，它返回：
        // "Angle { Degrees = 90, Minutes = 0, Seconds = 0, Name =  }"
        Console.WriteLine(angle.ToString());

        // 记录有一个使用了位置参数的解构函数
        if (angle is (int, int, int, string) angleData)
        {
            Trace.Assert(angle.Degrees == angleData.Degrees);
            Trace.Assert(angle.Minutes == angleData.Minutes);
            Trace.Assert(angle.Seconds == angleData.Seconds);
        }

        Angle copy = new(degrees, minutes, seconds);       
        // 记录提供了一个自定义的相等性操作符
        Trace.Assert(angle == copy);

        // with操作符等价于：
        // Angle copy = new(degrees, minutes, seconds);
        copy = angle with { };
        Trace.Assert(angle == copy);

        // with操作符支持“对象初始化器”语法，
        // 用于实例化一个修改过的拷贝。        
        Angle modifiedCopy = angle with { Degrees = 180 };
        Trace.Assert(angle != modifiedCopy);
    }
}
#endregion INCLUDE
