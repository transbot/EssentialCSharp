// This is pseudo code to represent the generated IL so guidelines not followed.
#pragma warning disable IDE0044 // Add readonly modifier
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable IDE1006 // Naming Styles

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_16;

using System;
#region INCLUDE
public class Thermostat
#region EXCLUDE
{
    // Used to suppress warning CS0469: field never assigned to, and 
    // will always have its default value null.
    public Thermostat(EventHandler<TemperatureArgs>? onTemperatureChange)
    {
        _OnTemperatureChange = onTemperatureChange;
    }

    // ...
    #endregion EXCLUDE
    // 声明委托字段来保存订阅者列表
    private EventHandler<TemperatureArgs>? _OnTemperatureChange;

    public void add_OnTemperatureChange(
        EventHandler<TemperatureArgs> handler)
    {
        System.Delegate.Combine(_OnTemperatureChange, handler);
    }

    public void remove_OnTemperatureChange(
        EventHandler<TemperatureArgs> handler)
    {
        System.Delegate.Remove(_OnTemperatureChange, handler);
    }

    #if ConceptualEquivalentCode
    public event EventHandler<TemperatureArgs> OnTemperatureChange
    {
        // 会造成编译错误
        add
        {
            add_OnTemperatureChange(value);
        }
        // 会造成编译错误
        remove
        {
            remove_OnTemperatureChange(value);
        }
    } 
    #endif // ConceptualEquivalentCode
    #endregion INCLUDE

    public class TemperatureArgs : System.EventArgs
    {
        public TemperatureArgs(float newTemperature)
        {
        }

    }
}
