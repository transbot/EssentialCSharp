using AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_05;
#region INCLUDE
// 使用record class构造来声明一个引用类型
public record class Coordinate(
    Angle Longitude, Angle Latitude)
#endregion INCLUDE
{
    public Type ExternalEqualityContract => EqualityContract;
}
