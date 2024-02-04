namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter23.Listing23_17;

using System;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        string text = "S5280ft";
        Console.Write("{0} = ", text);
        unsafe // 编译时要使用/unsafe开关
        {
            fixed(char* pText = text)
            {
                char* p = pText;
                *++p = 'm';
                *++p = 'i';
                *++p = 'l';
                *++p = 'e';
                *++p = ' ';
                *++p = ' ';
            }
        }
        Console.WriteLine(text);
        #endregion INCLUDE
    }
}
