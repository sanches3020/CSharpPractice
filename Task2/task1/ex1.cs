using System;

class task1
{
    static void Main()
    {
        int[] numbers = { -5, 2, 8, -2, 7, 10, -1, 4 };

        int countPositive = 0;
        int[] positiveNumbers = Array.FindAll(numbers, n => n > 0);

        Console.WriteLine("Положительные числа массива: ");
        foreach (int number in positiveNumbers)
        {
            Console.WriteLine(number);
            countPositive++;
        }

        Console.WriteLine($"Количество положительных элементов: {countPositive}");
    }
}
