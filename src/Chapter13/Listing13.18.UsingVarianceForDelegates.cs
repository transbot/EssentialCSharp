// 说明 : Left as lambda to elucidate generic types.
#pragma warning disable IDE0039 // Use local function
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter13.Listing13_18;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // 逆变
        Action<object> broadAction =
            (object data) =>
            {
                Console.WriteLine(data);
            };

        Action<string> narrowAction = broadAction;

        // 协变
        Func<string?> narrowFunction =
            () => Console.ReadLine();
        Func<object?> broadFunction = narrowFunction;

        // 同时使用逆变和协变
        Func<object, string?> func1 =
            (object data) => data.ToString();

        Func<string, object?> func2 = func1;
        #endregion INCLUDE
    }
}