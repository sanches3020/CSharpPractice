using System;
    
    class Program
{
    public static void SortInc3(ref double A, ref double B, ref double C)
    {
        if (A > B)
        {
            (A, B) = (B, A);
        }
        if (A > C)
        {
            (A, C) = (C, A);
        }
        if (B > C)
        {
            (B, C) = (C, B);
        }
    }

    static void Main()
    {
        double A1 = 3.0, B1 = 1.5, C1 = 2.0;
        double A2 = 5.0, B2 = 4.5, C2 = 6.0;

        SortInc3(ref A1, ref B1, ref C1);
        SortInc3(ref A2, ref B2, ref C2);

        Console.WriteLine($"Упорядоченные числа для первого набора: {A1}, {B1}, {C1}");
        Console.WriteLine($"Упорядоченные числа для второго набора: {A2}, {B2}, {C2}");
    }
}