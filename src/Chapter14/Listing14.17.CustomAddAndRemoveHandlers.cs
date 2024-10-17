namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_17;

#region INCLUDE
public class Thermostat
{
    public class TemperatureArgs : System.EventArgs
    #region EXCLUDE
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature { get; set; }
    }
 
    // 定义委托数据类型
    public delegate void EventHandler<TemperatureArgs>(
        object sender, TemperatureArgs newTemperature);
    #endregion EXCLUDE
    #region HIGHLIGHT
    // 定义事件发布者
    public event EventHandler<TemperatureArgs> OnTemperatureChange
    {
        add
        {
            _OnTemperatureChange = 
                (EventHandler<TemperatureArgs>)
                    System.Delegate.Combine(value, _OnTemperatureChange);
        }
        remove
        {
            _OnTemperatureChange = 
                (EventHandler<TemperatureArgs>?)
                    System.Delegate.Remove(_OnTemperatureChange, value);
        }
    }
    protected EventHandler<TemperatureArgs>? _OnTemperatureChange;
    #endregion HIGHLIGHT

    public float CurrentTemperature
    #region EXCLUDE
    {
        set
        {
            if (value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                // 如果存在任何订阅者，就调用
                // 它们注册的委托，将温度的变化
                // 通知它们。
                _OnTemperatureChange?.Invoke( // C# 6.0
                      this, new TemperatureArgs(value));
            }
        }
        get { return _CurrentTemperature; }
    }
    #endregion EXCLUDE
    private float _CurrentTemperature;
}
#endregion INCLUDE
