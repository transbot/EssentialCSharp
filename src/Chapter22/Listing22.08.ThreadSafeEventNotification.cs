namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter22.Listing22_08;

delegate void TemperatureChangedHandler(Program one, TemperatureEventArgs two);

class Program
{
    private static TemperatureChangedHandler OnTemperatureChanged = delegate { };

    public void Main()
    {

#if(!PreCSharp6)
        OnTemperatureChanged?.Invoke(
            this, new TemperatureEventArgs(value));
#else
        #region INCLUDE
        //...
        TemperatureChangedHandler localOnChange =
            OnTemperatureChanged;
        if(localOnChange is not null)
        {
            // 调用所有订阅了该事件的订阅者
            localOnChange(
              this, new TemperatureEventArgs(value));
        }
        //...
        #endregion INCLUDE
#endif
    }

    // 刻意使用小写的value作为属性名，
    // 以模拟setter中的value关键字。
#pragma warning disable IDE1006 // 命名风格
    public object? value { get; set; }
#pragma warning restore IDE1006 // 命名风格
}

public class TemperatureEventArgs
{
    public TemperatureEventArgs(object? _)
    {
        // ...
    }
}
