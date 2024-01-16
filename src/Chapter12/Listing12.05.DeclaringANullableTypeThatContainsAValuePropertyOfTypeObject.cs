namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_05;

#region INCLUDE
struct Nullable
{
    /// <summary>
    /// 在HasValue返回true时提供值
    /// </summary>
    public object Value { get; private set; }

    /// <summary>
    /// 该属性指出是真的有一个值，还是值为"null"
    /// </summary>
    public bool HasValue { get; private set; }

    // ...
}
#endregion INCLUDE
