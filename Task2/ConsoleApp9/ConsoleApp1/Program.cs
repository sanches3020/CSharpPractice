using System;

class task9l3
{
    static void Main()
    {
        Console.Write("Введите строку для проверки URL: ");
        string inputUrl = Console.ReadLine();

        if (IsValidUrl(inputUrl))
        {
            Console.WriteLine($"\"{inputUrl}\" является корректным URL.");
        }
        else
        {
            Console.WriteLine($"\"{inputUrl}\" не является корректным URL.");
        }
    }

    static bool IsValidUrl(string url)
    {
.
        Uri uriResult;
        bool isValid = Uri.TryCreate(url, UriKind.RelativeOrAbsolute, out uriResult) &&
                       (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        return isValid;
    }
}