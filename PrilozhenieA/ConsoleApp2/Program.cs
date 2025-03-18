using System;

class Program
{
    static void Main()
    {
     
        Console.Write("Введите трёхзначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 100 || number > 999)
        {
            Console.WriteLine("Введите корректное трёхзначное число.");
            return;
        }

        int first = number / 100; 
        int last = number % 10;    

        int product = first * last;

        Console.WriteLine($"Произведение первой и последней цифр: {product}");
    }
}