namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_21;

using System;
using Listing17_10;
using System.Collections.Generic;

#region INCLUDE
public struct Pair<T> : IPair<T>, IEnumerable<T>
{
    #region EXCLUDE
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

    // 代码清单17.21  在返回IEnumerable<T>的方法中使用yield return
    #endregion EXCLUDE
    #region HIGHLIGHT
    public IEnumerable<T> GetReverseEnumerator()
    #endregion HIGHLIGHT
    {
        yield return Second;
        yield return First;
    }
    #region EXCLUDE
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
public class Program
{
    #endregion EXCLUDE
    public static void Main()
    {
        var game = new Pair<string>("Redskins", "Eagles");
        #region HIGHLIGHT
        foreach (string name in game.GetReverseEnumerator())
        #endregion HIGHLIGHT
        {
            Console.WriteLine(name);
        }
    }
    #endregion INCLUDE
}
