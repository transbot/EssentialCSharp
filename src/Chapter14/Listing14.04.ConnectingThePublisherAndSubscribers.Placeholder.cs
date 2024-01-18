namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter14.Listing14_04;

using System;
using Listing14_01;

public class Program
{
    public static void Main()
    {
        Thermostat thermostat = new();
        Heater heater = new(60);
        Cooler cooler = new(80);

        thermostat.OnTemperatureChange +=
            heater.OnTemperatureChanged;
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