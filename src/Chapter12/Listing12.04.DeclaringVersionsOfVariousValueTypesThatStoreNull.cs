namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_04;

using System;

#region INCLUDE
struct NullableInt
{
    /// <summary>
    /// 在HasValue返回true时提供值
    /// </summary>
    public int Value { get; private set; }

    /// <summary>
    /// 该属性指出是真的有一个值，还是值为"null"
    /// </summary>
    public bool HasValue { get; private set; }

    // ...
}

struct NullableGuid
{
    /// <summary>
    /// 在HasValue返回true时提供值
    /// </summary>
    public Guid Value { get; private set; }

    /// <summary>
    /// 该属性指出是真的有一个值，还是值为"null"
    /// </summary>
    public bool HasValue { get; private set; }

    // ...
}

// ...
#endregion INCLUDE
