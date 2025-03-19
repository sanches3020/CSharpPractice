using System;

class Program
{
    static void Main()
    {
  
        Console.Write("Введите строку для проверки URL: ");
        string inputUrl = Console.ReadLine(); 

        if (IsUrlValid(inputUrl))
        {
            Console.WriteLine($"\"{inputUrl}\" является корректным URL."); 
        }
        else
        {
            Console.WriteLine($"\"{inputUrl}\" не является корректным URL."); 
        }
    }

    static bool IsUrlValid(string url)
    {
        
        Uri uriResult;
        bool isValid = Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out uriResult);
        return isValid; 
        }
}