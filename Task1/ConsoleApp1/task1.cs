using System;
using System.Reflection.Metadata;

class task1
{ 
    static void Main()
    {
        Console.Write("Введите сторону A: ");
        double A = double.Parse(Console.ReadLine());

        Console.Write("Введите сторону B: ");
        double B = double.Parse(Console.ReadLine());

        Console.Write("Введите сторону C: ");
        double C = double.Parse(Console.ReadLine());

        double P = A + B + C;

        double d = Math.Sqrt(A * A + B * B);

        Console.WriteLine($"Периметр прямоугольника: {P}");
        Console.WriteLine($"Длина диагонали прямоугольника: {d:F2}");
    }
}

