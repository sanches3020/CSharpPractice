using System;
    
    class Program
{
    static void Main()
    {
        Console.WriteLine("Введите a:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите b:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите c:");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine($"({a:F4} + ({b:F4} + {c:F4})) = ({a:F4} + {c:F4} + {b:F4})");
    }
}
