using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string input = Console.ReadLine();
        Console.Write("Введите длину подстроки: ");
        int length = int.Parse(Console.ReadLine());

        SplitString(input, length);
    }

    static void SplitString(string str, int length)
    {
        for (int i = 0; i < str.Length; i += length)
        {
            if (i + length > str.Length)
                length = str.Length - i; 

            string substring = str.Substring(i, length);
            Console.WriteLine(substring);
        }
    }
}