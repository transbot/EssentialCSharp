namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_02;

using System;
#region INCLUDE
public class Thermostat
{
    // 定义事件发布者(最开始没有sender)
    public Action<float>? OnTemperatureChange { get; set; }

    public float CurrentTemperature { get; set; }
    #endregion INCLUDE
}