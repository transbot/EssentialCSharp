using AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_12;

#region INCLUDE
using System;

public class BinaryTree<T> 
{
    #region EXCLUDE
    public BinaryTree(T value)
    {
        Value = value;
    }

    /// <summary>
    /// 返回位于特定位置的BinaryTree<typeparamref name="T"/>
    /// </summary>
    /// <param name="branches">指向特定分支的一个PairItems数组。</param>
    /// <example>
    /// familyTree.SubItems.Second.SubItems[PairItem.First].Value
    /// </example>
    #endregion EXCLUDE
    public BinaryTree<T> this[params PairItem[]? branches]
    {
        get
        {
            BinaryTree<T> currentNode = this;

            // 允许使用空数组或null来引用根节点
            int totalLevels = branches?.Length ?? 0;
            int currentLevel = 0;

            while (currentLevel < totalLevels)
            {
                System.Diagnostics.Debug.Assert(branches is not null,
                    $"{ nameof(branches) }不为null");

                currentNode = currentNode.SubItems[
                    branches[currentLevel]];
                if (currentNode is null)
                {
                    // 此位置的二叉树为null
                    throw new IndexOutOfRangeException();
                }
                currentLevel++;
            }
            return currentNode;
        }
    }
    #region EXCLUDE

    public T Value { get; set; }

    public Pair<BinaryTree<T>> SubItems {get;set;}
    #endregion EXCLUDE
}
#endregion INCLUDE

public class Program
{
    public static void Main()
    {
        // JFK(肯尼迪)家族族谱
        var jfkFamilyTree = new BinaryTree<string>(
            "John Fitzgerald Kennedy")
        {
            SubItems = new Pair<BinaryTree<string>>(
                new BinaryTree<string>("Joseph Patrick Kennedy")
                {
                    // 祖父母（父亲那边）
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("Patrick Joseph Kennedy"),
                        new BinaryTree<string>("Mary Augusta Hickey"))
                },
                new BinaryTree<string>("Rose Elizabeth Fitzgerald")
                {
                    // 外祖父母（母亲那边）
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("John Francis Fitzgerald"),
                        new BinaryTree<string>("Mary Josephine Hannon"))
                })
        };

        // 上述二叉树的结构如下所示：
        // John Fitzgerald Kennedy（这是大家熟知的美国总统肯尼迪）
        //     Joseph Patrick Kennedy（肯尼迪的老爸）
        //         Patrick Joseph Kennedy（肯尼迪的祖父）
        //         Mary Augusta Hickey（肯尼迪的祖母）
        //     Rose Elizabeth Fitzgerald（肯尼迪的老妈）
        //         John Francis Fitzgerald（肯尼迪的外祖父）
        //         Mary Josephine Hannon（肯尼迪的外祖母）

        Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.First].Value);
        Console.WriteLine(jfkFamilyTree[PairItem.Second, PairItem.Second].Value);
    }
}
