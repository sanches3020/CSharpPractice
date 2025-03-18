using System;

class task4
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());
        double y;

        if (x > 1 && x < 2)
        {
         
            y = Math.Pow(x - 2, 2) + 6;
        }
        else if (x >= 2)
        {
         
            y = Math.Log(x + 3 * Math.Sqrt(x));
        }
        else
        {
            Console.WriteLine("Значение x должно быть больше 1.");
            return;
        }
        Console.WriteLine($"Значение y при x = {x}: {y}");
    }
}