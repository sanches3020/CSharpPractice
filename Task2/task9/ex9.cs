using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        StringBuilder sb = new StringBuilder(Console.ReadLine());
        Console.Write("Введите подстроку для поиска: ");
        string substring = Console.ReadLine();

        int index = FindFirstOccurrence(sb, substring);

        if (index != -1)
        {
            Console.WriteLine($"Первое вхождение подстроки \"{substring}\" найдено на индексе {index}.");
        }
        else
        {
            Console.WriteLine($"Подстрока \"{substring}\" не найдена.");
        }
    }

    static int FindFirstOccurrence(StringBuilder sb, string substring)
    {
        return sb.ToString().IndexOf(substring);
    }
}