namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_15;

using System;
using Listing17_10;

using System.Collections.Generic;
#region INCLUDE
public struct Pair<T> : IPair<T>,
#region HIGHLIGHT
IEnumerable<T>
#endregion HIGHLIGHT
{
    public Pair(T first, T second) : this()
    {
        First = first;
        Second = second;
    }
    public T First { get; }
    public T Second { get; }
    #region EXCLUDE
    #region Indexer
    public T this[PairItem index]
    {
        get
        {
            switch(index)
            {
                case PairItem.First:
                    return First;
                case PairItem.Second:
                    return Second;
                default:
                    throw new NotImplementedException(
                        string.Format(
                        "尚未实现{0}枚举",
                        index.ToString()));
            }
        }
    #endregion Indexer
    }
    #endregion EXCLUDE
    #region HIGHLIGHT
    #region IEnumerable<T>的成员
    public IEnumerator<T> GetEnumerator()
    {
        yield return First;
        yield return Second;
    }
    #endregion IEnumerable<T>的成员

    #region IEnumerable的成员
    System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion IEnumerable的成员
    #endregion HIGHLIGHT
}
#endregion INCLUDE
