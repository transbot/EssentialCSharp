namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_12;

using Listing12_08;
#region INCLUDE
public struct Pair<T> : IPair<T>
{
    // 错误: 字段'Pair<T>.Second'必须赋值，控制才能返回调用方    
    // public Pair(T first)
    // {  
    //     First = first;
    // }

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
