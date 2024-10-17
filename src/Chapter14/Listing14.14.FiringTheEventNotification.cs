namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_14;

using System;
#region INCLUDE
public class Thermostat
#region EXCLUDE
{
    public class TemperatureArgs : System.EventArgs
    {
        public TemperatureArgs(float newTemperature)
        {
            NewTemperature = newTemperature;
        }

        public float NewTemperature { get; set; }
    }

    // 定义事件发布者
    public event EventHandler<TemperatureArgs> OnTemperatureChange =
        delegate { };
    #endregion EXCLUDE

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            if(value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                // 如果存在任何订阅者，就调用
                // 它们注册的委托，将温度的变化
                // 通知它们。
                #region HIGHLIGHT
                OnTemperatureChange?.Invoke(
                      this, new TemperatureArgs(value));
                #endregion HIGHLIGHT
            }
        }
    }
    private float _CurrentTemperature;
}
#endregion INCLUDE
