namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_19;

using System;
using Listing17_10;
using System.Collections.Generic;

public struct Pair<T> : IPair<T>, IEnumerable<T>
{
    #region Members
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }
    public T First { get; }
    public T Second { get; }

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
    }
    #endregion Members

    // 代码清单17.19  用yield break取消迭代
    #region INCLUDE
    public System.Collections.Generic.IEnumerable<T> GetNotNullEnumerator()
    {
        #region HIGHLIGHT
        if ((First is null) || (Second is null))
        {
            yield break;
        }
        #endregion HIGHLIGHT
        yield return Second;
        yield return First;
    }
    #endregion INCLUDE

    

    #region IEnumerable<T>
    public IEnumerator<T> GetEnumerator()
    {
        yield return First;
        yield return Second;
    }
    #endregion IEnumerable<T>

    #region IEnumerable的成员
    System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion
}
