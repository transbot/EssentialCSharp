namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_11;

public class Program
{
#pragma warning disable CA1822 // 将成员标记为static
    #region INCLUDE
    [return: Description(
       "如果对象处于有效状态，就返回true。")]
    public bool IsValid()
    {
        // ...
        return true;
    }
    #endregion INCLUDE
#pragma warning restore CA1822 // 将成员标记为static
}

public class DescriptionAttribute : Attribute
{
    private readonly string _Description;
    public string Description { get { return _Description; } }

    public DescriptionAttribute(string description)
    {
        this._Description = description;
    }
}