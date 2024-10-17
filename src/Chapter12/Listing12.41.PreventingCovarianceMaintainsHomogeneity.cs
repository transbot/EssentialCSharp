namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_41;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // ...
        Contact contact1 = new("Princess Buttercup");
        Contact contact2 = new("Inigo Montoya");
        Pair<Contact> contacts = new(contact1, contact2);

        #region HIGHLIGHT
        #if COMPILEERROR // EXCLUDE
        // 会报告错误：不能转换类型 ...
        // 但假定不报错
        IPair<PdaItem> pdaPair = (IPair<PdaItem>) contacts;
        // 这完全合法，但不是类型安全的
        pdaPair.First = new Address("123 Sesame Street");
        #endif // COMPILEERROR // EXCLUDE
        #endregion HIGHLIGHT
        #endregion INCLUDE
    }
}

public class Address : PdaItem
{
    public Address(string address) : base(address)
    {
    }
}

public struct Pair<T> : IPair<T>
{
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }

    public T First { get; set; }
    public T Second { get; set; }
}

interface IPair<T>
{
    T First { get; set; }
    T Second { get; set; }
}

public class Contact : PdaItem
{
    public Contact(string name)
        : base(name)
    {
    }
}

public abstract class PdaItem
{
    public PdaItem(string name)
    {
        Name = name;
    }

    public virtual string Name { get; set; }
}
