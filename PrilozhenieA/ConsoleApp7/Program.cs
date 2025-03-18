using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите длину стороны a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите длину стороны c: ");
        double c = double.Parse(Console.ReadLine());

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Треугольник с такими сторонами не существует.");
            return;
        }

        double s = (a + b + c) / 2;

        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        double height = (2 * area) / a;

        Console.WriteLine($"Высота треугольника, опущенная на сторону a: {height:F4}");
    }
}