namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter17.Listing17_10;

using System;

// ----
#region INCLUDE
interface IPair<T>
{
    T First { get; }
    T Second { get; }
    #region HIGHLIGHT
    T this[PairItem index] { get; }
    #endregion HIGHLIGHT
}

public enum PairItem
{
    First,
    Second
}

public struct Pair<T> : IPair<T>
{
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public T First { get; }
    public T Second { get; }

    #region HIGHLIGHT
    public T this[PairItem index]
    {
        get
        {
            #endregion HIGHLIGHT
            switch (index)
            {
                case PairItem.First:
                    return First;
                case PairItem.Second:
                    return Second;
                default:
                    throw new NotImplementedException(
                        $"尚未实现{index.ToString()}枚举。");

            }
        }
        #region EXCLUDE

        /*  
        // 为了与“结构应只读”原则一致，这里将setter注释掉了

        set
        {
            switch(index)
            {
                case PairItem.First:
                    First = value;
                    break;
                case PairItem.Second:
                    Second = value;
                    break;
                default:
                    throw new NotImplementedException(
                        string.Format(
                        "{0}枚举尚未实现",
                        index.ToString()));
            }
        }
        */
        #endregion EXCLUDE
        #region HIGHLIGHT
    }
    #endregion HIGHLIGHT
}
#endregion INCLUDE
