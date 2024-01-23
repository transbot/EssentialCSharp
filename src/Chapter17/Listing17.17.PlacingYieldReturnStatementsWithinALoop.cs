namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_17;

using System.Collections.Generic;
using Listing17_15;
#region INCLUDE
public class BinaryTree<T> :
  IEnumerable<T>
{
    #region EXCLUDE
    public BinaryTree(T value)
    {
        Value = value;
    }
    #endregion EXCLUDE
    #region IEnumerable<T>的成员
    public IEnumerator<T> GetEnumerator()
    {
        // 返回这个节点的item
        yield return Value;

        // 遍历pair的每个元素
        #region HIGHLIGHT
        foreach (BinaryTree<T>? tree in SubItems)
        {
            if(tree is not null)
            {
                // 由于pair中的每个元素都是树，
                // 所以遍历树，并yield每个元素。
                foreach(T item in tree)
                {
                    yield return item;
                }
            }
        }
        #endregion HIGHLIGHT
    }
    #endregion IEnumerable<T>的成员

    #region IEnumerable的成员
    System.Collections.IEnumerator
        System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    #endregion
    #region EXCLUDE
    public T Value { get; }  // C# 6.0开始可以写仅getter的自动属性

    public Pair<BinaryTree<T>> SubItems { get; set; }
    #endregion EXCLUDE
}
#endregion INCLUDE
