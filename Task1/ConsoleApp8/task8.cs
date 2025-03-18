using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число A (1 <= A <= 100): ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Введите целое число B (A < B, B <= 100): ");
        int B = int.Parse(Console.ReadLine());

        if (A < 1 || A > 100 || B <= A || B > 100)
        {
            Console.WriteLine("Введите корректные значения для A и B.");
            return;
        }

        int sum = 0;

        for (int i = A; i <= B; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Сумма целых чисел от {A} до {B} включительно: {sum}");
    }
}