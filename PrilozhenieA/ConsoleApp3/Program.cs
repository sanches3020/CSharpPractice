using System;

class Program
{ 
    static void Main()
    {
        double[] testm = { 1, 2, 3, 4 };
        double[] testn = { 1, 2, 3, 4 };
        Console.WriteLine();

        foreach (double m in testm)
        {
            foreach (double n in testn)
            {
                double z1 = CalculateZ1(m, n);
                double z2 = CalculateZ2(m, n);

                Console.WriteLine($"{m}\t {n}\t {z1:F6}\t {z2:F6}");
            }
        }
    }

    static double CalculateZ1(double m, double n)
    {
        return (m - 1) * Math.Sqrt(m - (n - 1) * Math.Sqrt(n)) /
               Math.Sqrt(Math.Pow(m, 3) + m * Math.Pow(n, 2) - m);
    }

    static double CalculateZ2(double m, double n)
    {
        return Math.Sqrt(m - Math.Sqrt(n)) / m;
    }
}

