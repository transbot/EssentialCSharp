namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter09.Listing09_27;

using System;

#region INCLUDE
interface IAngle
{
    void MoveTo(int degrees, int minutes, int seconds);
}

struct Angle : IAngle
{
    #region EXCLUDE
    public Angle(int degrees, int minutes, int seconds)
    {
        _Degrees = degrees;
        _Minutes = minutes;
        _Seconds = seconds;
    }
    #endregion EXCLUDE

    // 注意:  这会使Angle“可变”，有违设计规范
    public void MoveTo(int degrees, int minutes, int seconds)
    {
        _Degrees = degrees;
        _Minutes = minutes;
        _Seconds = seconds;
    }
    #region EXCLUDE
    public int Degrees
    {
        get { return _Degrees; }
    }
    private int _Degrees;

    public int Minutes
    {
        get { return _Minutes; }
    }
    private int _Minutes;

    public int Seconds
    {
        get { return _Seconds; }
    }
    private int _Seconds;
    #endregion EXCLUDE
}
public class Program
{
    public static void Main()
    {
        // ...

        Angle angle = new(25, 58, 23);
        // 例1: 简单装箱操作
        object objectAngle = angle;  // 装箱
        Console.Write(((Angle)objectAngle).Degrees);

        // 例2: 拆箱，修改已拆箱的值，然后丢弃值
        ((Angle)objectAngle).MoveTo
            (26, 58, 23);
        Console.Write(", " + ((Angle)objectAngle).Degrees);

        // 例3: 装箱，修改已装箱的值，然后丢弃对箱子的引用
        ((IAngle)angle).MoveTo(26, 58, 23);
        Console.Write(", " + ((Angle)angle).Degrees);

        // 例4: 直接修改已装箱的值
        ((IAngle)objectAngle).MoveTo(26, 58, 23);
        Console.WriteLine(", " + ((Angle)objectAngle).Degrees);

        // ...
    }
}
#endregion INCLUDE
