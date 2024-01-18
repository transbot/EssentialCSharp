namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_09;

using System;
using System.Collections.Generic;
using Listing14_01;
#region INCLUDE
public class Thermostat
{
    // 定义事件发布者
    public Action<float>? OnTemperatureChange;

    public float CurrentTemperature
    {
        get { return _CurrentTemperature; }
        set
        {
            if(value != CurrentTemperature)
            {
                _CurrentTemperature = value;
                Action<float>? onTemperatureChange 
                    = OnTemperatureChange;
                if (onTemperatureChange is not null)
                {
                    #region HIGHLIGHT
                    List<Exception> exceptionCollection =
                        new();
                    foreach(
                        Delegate handler in
                        onTemperatureChange.GetInvocationList())
                    {
                        try
                        {
                            ((Action<float>)handler)(value);
                        }
                        catch(Exception exception)
                        {
                            exceptionCollection.Add(exception);
                        }
                    }
                    if(exceptionCollection.Count > 0)
                    {
                        throw new AggregateException(
                            "有异常从" +
                            "OnTemperatureChange事件订阅者抛出。",
                            exceptionCollection);
                    }
                    #endregion HIGHLIGHT
                }
            }
        }
    }
    private float _CurrentTemperature;
}
#endregion INCLUDE

public class Program
{
    public static void Main()
    {
        try
        {
            Thermostat thermostat = new();
            Heater heater = new(60);
            Cooler cooler = new(80);

            thermostat.OnTemperatureChange +=
                heater.OnTemperatureChanged;
            thermostat.OnTemperatureChange +=
                (newTemperature) =>
                {
                    throw new InvalidOperationException();
                };
            thermostat.OnTemperatureChange +=
                cooler.OnTemperatureChanged;

            Console.Write("输入温度: ");
            string? temperature = Console.ReadLine();
            if (!int.TryParse(temperature, out int currentTemperature))
            {
                Console.WriteLine($"'{temperature}' 不是一个有效的整数。");
                return;
            }
            thermostat.CurrentTemperature = currentTemperature;
        }
        catch(AggregateException exception)
        {
            Console.WriteLine(exception.Message);
            if (exception.InnerExceptions.Count > 1)
            {
                // 异常超过1个时才枚举这些异常，因为如果只有一个异常，
                // 它的消息已经合并到AggregateException的消息中了。                
                foreach (Exception item in exception.InnerExceptions)
                {
                    Console.WriteLine("\t{0}: {1}",
                        item.GetType(), item.Message);
                }
            }
        }
    }
}
