using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        var input = Console.ReadLine();
        var result = LongestUniqueSubstring(input);
        Console.WriteLine(result);
    }

    static string LongestUniqueSubstring(string s)
    {
        var chars = new HashSet<char>();
        int l = 0;
        string longest = "";

        for (int r = 0; r < s.Length; r++)
        {
            while (chars.Contains(s[r]))
            {
                chars.Remove(s[l++]);
            }
            chars.Add(s[r]);
            if (r - l + 1 > longest.Length)
            {
                longest = s.Substring(l, r - l + 1);
            }
        }

        return longest;
    }
}