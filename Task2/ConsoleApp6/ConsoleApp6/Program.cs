using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        var input = Console.ReadLine();
        var result = FindLongestUniqueSubstring(input);
        Console.WriteLine($"Подстрока максимальной длины с уникальными символами: {result}");
    }

    static string FindLongestUniqueSubstring(string s)
    {
        var uniqueChars = new HashSet<char>();
        int left = 0;
        string longestSubstring = "";

        for (int right = 0; right < s.Length; right++)
        {
            while (uniqueChars.Contains(s[right]))
            {
                uniqueChars.Remove(s[left++]);
            }
            uniqueChars.Add(s[right]);
            if (right - left + 1 > longestSubstring.Length)
            {
                longestSubstring = s.Substring(left, right - left + 1);
            }
        }

        return longestSubstring;
    }
}