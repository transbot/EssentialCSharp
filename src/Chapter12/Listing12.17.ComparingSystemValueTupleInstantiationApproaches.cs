namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_17;

#pragma warning disable 0219 // Disabled warning for assigned but never 
// used variables for elucidation
using Contact = Chapter12.Contact;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
#if !PRECSHARP7
        (string, Contact) keyValuePair;
        keyValuePair =
            ("555-55-5555", new Contact("Inigo Montoya"));
#else // C# 7.0以前使用System.Tuple<string, Contact>
        Tuple<string, Contact> keyValuePair;
        keyValuePair =
            Tuple.Create(
                "555-55-5555", new Contact("Inigo Montoya"));
        keyValuePair =
            new Tuple<string, Contact>(
                "555-55-5555", new Contact("Inigo Montoya"));
#endif // !PRECSHARP7

        #endregion INCLUDE
    }
}
