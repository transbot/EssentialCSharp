namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_13;

#region INCLUDE
using System.Collections;
using System.Collections.Generic;

public class BinaryTree<T> :
#region HIGHLIGHT
IEnumerable<T>
#endregion HIGHLIGHT
{
    public BinaryTree(T value)
    {
        Value = value;
    }

    #region IEnumerable<T>的成员
    #region HIGHLIGHT
    public IEnumerator<T> GetEnumerator()
    #endregion HIGHLIGHT
    {
        #region EXCLUDE
        return new List<T>.Enumerator(); // 下个代码清单实现，这里只是摆个样子
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator(); // 下个代码清单实现，这里只是摆个样子
        #endregion EXCLUDE
    }
    #endregion IEnumerable<T>的成员

    public T Value { get; }
    public Pair<BinaryTree<T>> SubItems { get; set; }
}

public struct Pair<T>
{
    public Pair(T first, T second) : this()
    {
        First = first;
        Second = second;
    }
    public T First { get; }
    public T Second { get; }
}
#endregion INCLUDE
