namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_08;

using System;
using Listing14_01;
using Listing14_05;
#region INCLUDE
public class Program
{
    public static void Main()
    {
        Thermostat thermostat = new();
        Heater heater = new(60);
        Cooler cooler = new(80);

        thermostat.OnTemperatureChange +=
            heater.OnTemperatureChanged;
        #region HIGHLIGHT
        thermostat.OnTemperatureChange +=
            (newTemperature) =>
                {
                    throw new InvalidOperationException();
                };
        #endregion HIGHLIGHT
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
}
#endregion INCLUDE
