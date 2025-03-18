using System;

class task2
{
    static void Main()
    {
        Console.Write("Введите трехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Число должно быть трехзначным.");
            return;
        }

        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int units = number % 10;

        if (hundreds < tens && tens < units)
        {
            Console.WriteLine("Цифры образуют возрастающую последовательность.");
        }
        else
        {
            Console.WriteLine("Цифры не образуют возрастающую последовательность.");
        }
    }
}
