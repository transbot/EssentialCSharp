namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_18;

using System;
using Listing17_15;
using Listing17_17;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // JFK(¿ÏÄáµÏ)¼Ò×å×åÆ×
        var jfkFamilyTree = new BinaryTree<string>(
            "John Fitzgerald Kennedy")
        {
            SubItems = new Pair<BinaryTree<string>>(
                new BinaryTree<string>("Joseph Patrick Kennedy")
                {
                    // ×æ¸¸Ä¸£¨¸¸Ç×ÄÇ±ß£©
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("Patrick Joseph Kennedy"),
                        new BinaryTree<string>("Mary Augusta Hickey"))
                },
                new BinaryTree<string>("Rose Elizabeth Fitzgerald")
                {
                    // Íâ×æ¸¸Ä¸£¨Ä¸Ç×ÄÇ±ß
                    SubItems = new Pair<BinaryTree<string>>(
                        new BinaryTree<string>("John Francis Fitzgerald"),
                        new BinaryTree<string>("Mary Josephine Hannon"))
                })
        };


        #region HIGHLIGHT
        foreach (string name in jfkFamilyTree)
        {
            Console.WriteLine(name);
        }
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}
