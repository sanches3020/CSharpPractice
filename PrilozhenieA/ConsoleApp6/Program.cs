using System;

class Program
{
    static void Main()
    {
        double x = 1.3; // Измените на любое значение для тестирования

        if (x < -1 || x > 1)
        {
            Console.WriteLine("Аргумент для арктангенса должен быть в диапазоне [-1, 1].");
        }
        else
        {
            double y = 2 * Math.Atan(Math.Sqrt(1 - x * x)) + Math.Log(7 * x) / (1 + Math.Exp(x));
            Console.WriteLine($"Значение функции y при x = {x}: {y:F4}");
        }
    }
}