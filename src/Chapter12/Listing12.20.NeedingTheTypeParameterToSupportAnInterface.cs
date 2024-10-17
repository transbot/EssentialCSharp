namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_20;

using System;
using Listing12_13;
// 在实际的实现中，Item应容纳一些值
#pragma warning disable CS0168
#region INCLUDE
public class BinaryTree<T>
{
    public BinaryTree(T item)
    {
        Item = item;
    }

    public T Item { get; set; }
    public Pair<BinaryTree<T>> SubItems
    {
        get { return _SubItems; }
        set
        {
            #region HIGHLIGHT
            IComparable<T> first;
            // 错误: 不支持类型隐式转换...
            //first = value.First;  // 需要显式转型

            //if(first.CompareTo(value.Second) < 0)
            //{
            //    // first小于second
            //    //...
            //}
            //else
            //{
            //    // first和second相等，或者
            //    // second小于first
            //    //...
            //}
            _SubItems = value;
            #endregion HIGHLIGHT
        }
    }
    private Pair<BinaryTree<T>> _SubItems;
}
#endregion INCLUDE
#pragma warning restore CS0168

