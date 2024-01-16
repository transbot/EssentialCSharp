namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_10;

using System.Collections.Generic;
#region INCLUDE
public interface IContainer<T>
{
    ICollection<T> Items { get; set; }
}

public class Person : IContainer<Address>,
    IContainer<Phone>, IContainer<Email>
{
    #region HIGHLIGHT
    ICollection<Address> IContainer<Address>.Items
    #endregion HIGHLIGHT
    {
        get
        {
            #region EXCLUDE
            return new List<Address>();
            #endregion EXCLUDE
        }
        set
        {
            //...
        }
    }
    #region HIGHLIGHT
    ICollection<Phone> IContainer<Phone>.Items
    #endregion HIGHLIGHT
    {
        get
        {
            #region EXCLUDE
            return new List<Phone>();
            #endregion EXCLUDE
        }
        set
        {
            //...
        }
    }
    #region HIGHLIGHT
    ICollection<Email> IContainer<Email>.Items
    #endregion HIGHLIGHT
    {
        get
        {
            #region EXCLUDE
            return new List<Email>();
            #endregion EXCLUDE
        }
        set
        {
            //...
        }
    }
}
#endregion INCLUDE

public class Address { } // 只是举例
public class Phone { } // 只是举例
public class Email { } // 只是举例
