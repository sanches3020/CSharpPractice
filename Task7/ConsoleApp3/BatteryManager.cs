using System;

namespace ConsoleApp3
{
    class BatteryManager
    {
        public void CheckBatteryLevel(int level)
        {
            if (level < 5)
            {
                throw new LowBatteryException($"Уровень заряда аккумулятора составляет {level}%. Зарядите устройство.");
            }

            Console.WriteLine($"Уровень заряда аккумулятора: {level}%. Уровень приемлемый.");
        }
    }
}

