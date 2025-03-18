using System;

class task5
{
    static void Main()
    {
        Console.Write("Введите длину стороны a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны c: ");
        double c = double.Parse(Console.ReadLine());

        if (a == b || b == c || a == c)
        {
            Console.WriteLine("Треугольник является равнобедренным.");
        }
        else
        {
            Console.WriteLine("Треугольник не является равнобедренным.");
        }
    }
}