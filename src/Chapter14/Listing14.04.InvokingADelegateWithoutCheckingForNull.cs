namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04;

using System;
#region INCLUDE
public class Thermostat
{
    #region EXCLUDE
    // 定义事件发布者
    public Action<float>? OnTemperatureChange { get; set; }
    #endregion EXCLUDE
    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            #region HIGHLIGHT
            if (value != CurrentTemperature)
            #endregion HIGHLIGHT
            {
                #region HIGHLIGHT
                _CurrentTemperature = value;
                #endregion HIGHLIGHT

                // 调用订阅者；
                // 未完成，需要进行null检查
                #region EXCLUDE
                #pragma warning disable CS8602 // 提领一个可能为null的引用
                #endregion EXCLUDE
                OnTemperatureChange(value);
                #region EXCLUDE
                #pragma warning restore CS8602 // 提领一个可能为null的引用
                #endregion EXCLUDE
            }
        }
    }
    private float _CurrentTemperature;
}
#endregion INCLUDE
