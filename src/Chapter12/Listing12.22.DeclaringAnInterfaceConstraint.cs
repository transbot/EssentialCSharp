namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_22;

using System;
using Listing12_13;

#region INCLUDE
public class BinaryTree<T>
    #region HIGHLIGHT
    where T : System.IComparable<T>
    #endregion HIGHLIGHT
{
    public BinaryTree(T item)
    {
        Item = item;
    }

    public T Item { get; set; }
    public Pair<BinaryTree<T>?> SubItems
    {
        get { return _SubItems; }
        set
        {
            switch (value)
            {                
                // C# 8.0应该使用模式匹配(is null)。
                // 但在C# 8.0之前，只能这样检查null
                #region EXCLUDE
                case { First: null }:
                    // First is null
                    break;
                case { Second: null }:
                    // Second is null
                    break;
                #endregion EXCLUDE
                case
                {
                    #region HIGHLIGHT
                    First: { Item: T first },
                    #endregion HIGHLIGHT
                    Second: { Item: T second }
                }:
                    #region HIGHLIGHT
                    if (first.CompareTo(second) < 0)
                    #endregion HIGHLIGHT
                    {
                        // first小于second
                    }
                    else
                    {
                        // second小于或等于first
                    }
                    break;
                default:
                    throw new InvalidCastException(
                        @$"不能对items排序，因为{typeof(T)}不支持IComparable<T>接口。"); 
            };
            _SubItems = value;
        }
    }
    private Pair<BinaryTree<T>?> _SubItems;
}
#endregion INCLUDE
