using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_04;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_15;

public class Program
{
    public static void Main()
    {
        // 构造函数根据位置参数来生成
        Angle angle = new(90, 0, 0, null);

        // 记录有一个使用了位置参数的解构函数
        #region INCLUDE
        if (angle is (int, int, int, string) angleData)
        {
            // ...
        }
        #endregion INCLUDE
    }
}
