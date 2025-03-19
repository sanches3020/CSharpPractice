using System;

class Task2
{
    static void Main()
    {
        Random random = new Random();
        int[] num = new int[100];

        for (int i = 0; i < num.Length; i++)
        {
            num[i] = random.Next(1, 1000);
        }

        Console.WriteLine("Сгенерированный массив:");
        Console.WriteLine(string.Join(", ", num));

        int max = num[0];
        int min = num[0];
        for (int i = 1; i < num.Length; i++)
        {
            if (num[i] > max)
                max = num[i];
            if (num[i] < min)
                min = num[i];
        }

        Array.Sort(num);

        Console.Write("Введите число k для поиска: ");
        int k = Convert.ToInt32(Console.ReadLine());

        int index = Array.BinarySearch(num, k);

        if (index >= 0)
        {
            Console.WriteLine($"Число {k} найдено по индексу {index}.");
        }
        else
        {
            Console.WriteLine($"Число {k} не найдено. Позиция для вставки: {~index}.");
        }

        int startIndex = Array.IndexOf(num, min);
        int endIndex = Array.IndexOf(num, max);

        if (startIndex > endIndex)
        {
            int temp = startIndex;
            startIndex = endIndex;
            endIndex = temp;
        }

        int sum = 0;
        int count = 0;

        for (int i = startIndex; i <= endIndex; i++)
        {
            sum += num[i];
            count++;
        }

        double average = (double)sum / count;
        Console.WriteLine($"Среднее арифметическое чисел между {min} и {max} включительно: {average}");
    }
}

