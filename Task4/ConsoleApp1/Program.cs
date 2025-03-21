using System;

public class StringUtil
{
    public static string ReverseUtil(string input)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input), "Входные данные не могут быть пустыми");
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
        string original = "Я программист";
        string reversed = StringUtil.ReverseUtil(original);
        Console.WriteLine(reversed);
    }
}