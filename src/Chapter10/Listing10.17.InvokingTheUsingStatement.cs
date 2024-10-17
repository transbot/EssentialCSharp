// 说明 : Use to demonstrate pre-C# 8.0 syntax.
#pragma warning disable IDE0063 // Use simple 'using' statement

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_17;

using Listing10_16;

#region INCLUDE
public static class Program
{
    public static void Search()
    {

        #region HIGHLIGHT
        // C# 8.0之前
        using (TemporaryFileStream fileStream2 =
            new(), fileStream3 = new())
        #endregion HIGHLIGHT
        {
            // 使用临时文件流
        }


        #region HIGHLIGHT
        // C# 8.0
        using TemporaryFileStream fileStream1 = new();
        #endregion HIGHLIGHT

        
    }
}
#endregion INCLUDE
