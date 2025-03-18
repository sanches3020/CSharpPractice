using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырехзначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1000 || number > 9999)
        {
            Console.WriteLine("Введите корректное четырехзначное число.");
            return;
        }

        int newNumber = (number % 1000 / 100) * 1000 + (number / 1000) * 100 + (number % 10) * 10 + (number / 10 % 10);
        Console.WriteLine($"Новое число: {newNumber}");
    }
}
