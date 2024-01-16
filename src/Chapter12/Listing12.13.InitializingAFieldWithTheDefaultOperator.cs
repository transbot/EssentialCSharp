// 说明 : 只显示部分实现
#pragma warning disable CS8618 // 不可为空的字段未初始化。考虑声明为可空。

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_13;

using Listing12_08;
#region INCLUDE
public struct Pair<T> : IPair<T>
{
    public Pair(T first)
    {
        First = first;
        #region EXCLUDE
        // 说明 : 忽略警告，本章稍后会添加struct/class约束，
        // 使Second可以声明为T?.
#pragma warning disable CS8601 // Possible null reference assignment.
        #endregion EXCLUDE
        #region HIGHLIGHT
        Second = default;
        #endregion HIGHLIGHT
        #region EXCLUDE
#pragma warning restore CS8601 // Possible null reference assignment.
        #endregion EXCLUDE
    }
    #region EXCLUDE
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public T First { get; set; }
    public T Second { get; set; }
    #endregion EXCLUDE
}
#endregion INCLUDE
