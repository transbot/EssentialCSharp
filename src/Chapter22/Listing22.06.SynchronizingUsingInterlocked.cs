// 说明 : Only partial implementation provided.
#pragma warning disable IDE0051 // Remove unused private members

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_06;

using System.Threading;
#region INCLUDE
public class SynchronizationUsingInterlocked
{
    private static object? _Data;

    // 如果_Data尚未赋值，就初始化它
    public static void Initialize(object newValue)
    {
        // 如果_Data为null，就把它设为newValue
        Interlocked.CompareExchange(
            ref _Data, newValue, null);
    }

    // ...
}
#endregion INCLUDE
