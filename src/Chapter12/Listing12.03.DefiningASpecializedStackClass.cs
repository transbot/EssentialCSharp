namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_03;

using Listing12_02;
#region INCLUDE
public class CellStack
{
    public virtual Cell Pop() { return new Cell(); } // 返回最后一个添加的cell，
                                                     // 并把它从栈中移除。
    public virtual void Push(Cell cell) { }
    // ...
}
#endregion INCLUDE
