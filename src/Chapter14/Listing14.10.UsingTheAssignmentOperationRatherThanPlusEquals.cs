using AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_02;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_10;

using System;
using Listing14_01;
#region INCLUDE
public class Program
{
    public static void Main()
    {
        Thermostat thermostat = new();
        Heater heater = new(60);
        Cooler cooler = new(80);

        thermostat.OnTemperatureChange =
            heater.OnTemperatureChanged;

        // Bug: 赋值操作符覆盖了之前的赋值
        #region HIGHLIGHT
        thermostat.OnTemperatureChange = 
            cooler.OnTemperatureChanged;
        #endregion HIGHLIGHT

        Console.Write("输入温度: ");
        string? temperature = Console.ReadLine();
        if (!int.TryParse(temperature, out int currentTemperature))
        {
            Console.WriteLine($"'{temperature}' 不是一个有效的整数。");
            return;
        }
        thermostat.CurrentTemperature = currentTemperature;
    }
}
#endregion INCLUDE
