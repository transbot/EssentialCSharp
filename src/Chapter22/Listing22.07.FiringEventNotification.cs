namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_07;

delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

public class Program
{
    private static readonly TemperatureChangedHandler OnTemperatureChanged = delegate { };

    public void Main()
    {
        #region INCLUDE
        // 非线程安全
        #region HIGHLIGHT
        if (OnTemperatureChanged is not null)
        #endregion HIGHLIGHT
        {
            // 调用所有订阅了该事件的订阅者
            OnTemperatureChanged(
                this, new TemperatureEventArgs(value));
        }
        #endregion INCLUDE
    }

    // 刻意使用小写的value作为属性名，
    // 以模拟setter中的value关键字。
    #pragma warning disable IDE1006 // 命名风格
    public object? value { get; set; }
    #pragma warning restore IDE1006 // 命名风格
}

class TemperatureEventArgs
{
    public TemperatureEventArgs(object? _)
    {
        // ...
    }
}
