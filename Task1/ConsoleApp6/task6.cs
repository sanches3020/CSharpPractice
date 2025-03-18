using System;

class task6
{
    static void Main()
    {
        Console.Write("Введите номер карты k (146 <= k <= 152): ");
        int k = int.Parse(Console.ReadLine());

        if (k < 146 || k > 152)
        {
            Console.WriteLine("Номер карты должен быть в диапазоне от 146 до 152.");
            return;
        }

        string rank;

        switch (k)
        {
            case 146:
                rank = "Шестёрка";
                break;
            case 147:
                rank = "Семёрка";
                break;
            case 148:
                rank = "Восьмёрка";
                break;
            case 149:
                rank = "Девятка";
                break;
            case 150:
                rank = "Десятка";
                break;
            case 151:
                rank = "Валет";
                break;
            case 152:
                rank = "Дама";
                break;
            default:
                rank = "Король"; 
                break;
        }

        if (k == 153)
        {
            rank = "Туз";
        }

        Console.WriteLine($"Достоинство карты: {rank}");
    }
}