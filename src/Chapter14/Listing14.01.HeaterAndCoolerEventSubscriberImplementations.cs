namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_01;

#region INCLUDE
public class Cooler
{
    public Cooler(float temperature)
    {
        Temperature = temperature;
    }

    //  当环境温度高于此值时，冷却器启动    
    public float Temperature { get; set; }

    // 当这个实例的温度发生变化时通知
    public void OnTemperatureChanged(float newTemperature)
    {
        if(newTemperature > Temperature)
        {
            System.Console.WriteLine("冷却器: On");
        }
        else
        {
            System.Console.WriteLine("冷却器: Off");
        }
    }
}

public class Heater
{
    public Heater(float temperature)
    {
        Temperature = temperature;
    }

    // 当环境温度低于此值时，加热器启动        
    public float Temperature { get; set; }

    // 当这个实例的温度发生变化时通知
    public void OnTemperatureChanged(float newTemperature)
    {
        if(newTemperature < Temperature)
        {
            System.Console.WriteLine("加热器: On");
        }
        else
        {
            System.Console.WriteLine("加热器: Off");
        }
    }
}
#endregion INCLUDE
