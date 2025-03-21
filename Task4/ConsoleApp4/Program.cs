using System;

public static class StringExtensions
{
    public static string Reverse(this string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input), "Входная строка не может быть null");
        }

        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку:");
        string original = Console.ReadLine();
        string reversed = original.Reverse();
        Console.WriteLine($"Обратная строка: {reversed}");
    }
}