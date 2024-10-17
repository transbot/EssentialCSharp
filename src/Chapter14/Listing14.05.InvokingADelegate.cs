namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_05;

using System;
#region INCLUDE
public class Thermostat
{
    // 定义事件发布者
    public Action<float>? OnTemperatureChange { get; set; }

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
                OnTemperatureChange?.Invoke(value);     // C# 6.0
                #endregion HIGHLIGHT
            }
        }
    }

    private float _CurrentTemperature;
}
#endregion INCLUDE
