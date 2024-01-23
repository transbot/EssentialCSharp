namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_11;

using System;

// ----

interface IPair<T>
{
    T First { get; }

    T Second { get; }

    T this[PairItem index] { get; }
}

// ----

public enum PairItem
{
    First,
    Second
}

// ----

public struct Pair<T> : IPair<T>
{
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public T First { get; } // C# 6.0引入的仅getter自动属性

    public T Second { get; } // C# 6.0引入的仅getter自动属性
    #region INCLUDE
    [System.Runtime.CompilerServices.IndexerName("Entry")]
    public T this[PairItem index]
    {
        #region EXCLUDE
        get
        {
            return index switch
            {
                PairItem.First => First,
                PairItem.Second => Second,
                _ => throw new NotImplementedException(
                     $"尚未实现{index}枚举"),
            };
        }
        #endregion EXCLUDE
    }
    #endregion INCLUDE
}
