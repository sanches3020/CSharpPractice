using ConsoleApp3;
using System;

class Program
{
    static void Main(string[] args)
    {
        BatteryManager batteryManager = new BatteryManager();


        Console.Write("Введите уровень заряда аккумулятора (в %): ");
        if (int.TryParse(Console.ReadLine(), out int batteryLevel))
        {
            try
            {
                batteryManager.CheckBatteryLevel(batteryLevel);
            }
            catch (LowBatteryException ex)
            {
           
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное значение уровня заряда аккумулятора.");
        }
    }
}