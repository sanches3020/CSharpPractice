using System;

class task7
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();
        Console.Write("Введите слово для поиска: ");
        string wordToFind = Console.ReadLine();

        if (ContainsSubstring(inputString, wordToFind))
        {
            Console.WriteLine($"Строка содержит слово \"{wordToFind}\".");
        }
        else
        {
            Console.WriteLine($"Строка не содержит слово \"{wordToFind}\".");
        }
    }

    static bool ContainsSubstring(string str, string word)
    {
        return str.Contains(word);
    }
}