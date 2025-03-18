using System;

class task9
{
    static void Main()
    {
        const double A = Math.PI / 8;
        const double B = 2 * Math.PI;
        const int M = 15;

        double H = (B - A) / M;

        Console.WriteLine("Таблица значений функции F(x) = sin(1/x):");
        Console.WriteLine(" x\t\t\t F(x)");

        for (int i = 0; i <= M; i++)
        {
            double x = A + i * H;
           
            double F_x = (x != 0) ? Math.Sin(1 / x) : 0;
            Console.WriteLine($"{x:F6}\t {F_x:F6}");
        }
    }
}