namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

#region INCLUDE
// 使用record struct构造来声明一个值类型
public readonly record struct Angle(
    int Degrees, int Minutes, int Seconds, string? Name = null);
#endregion INCLUDE
