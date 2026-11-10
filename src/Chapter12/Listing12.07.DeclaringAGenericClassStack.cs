namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_07;

#region INCLUDE
public class Stack<T>
{
    public Stack(int maxSize)
    {
        InternalItems = new T[maxSize];
    }

    private T[] InternalItems { get; }

    public void Push(T data)
    {
        //...
    }

    public T Pop()
    {
        #region EXCLUDE
        return InternalItems[0]; // 只是举例
        #endregion EXCLUDE
    }
}
#endregion INCLUDE
