using System;

class task3
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 10)
        {
            Console.WriteLine("Число N должно быть в диапазоне от 1 до 10.");
            return;
        }

        int sum = 0;

        for (int i = n; i <= 2 * n; i++)
        {
            sum += i * i; 
        }

        Console.WriteLine($"Сумма N^2 + (N + 1)^2 + (N + 2)^2 + ... + (2*N)^2 = {sum}");
    }
}
