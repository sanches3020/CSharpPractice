using System;

class Program
{
    public static bool IsSorted(int[] array, int index = 0)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Массив не должен быть пустым");
        }

        if (index == array.Length - 1)
        {
            return true;
        }

        if (array[index] > array[index + 1])
        {
            return false;
        }

        return IsSorted(array, index + 1);
    }

    static void Main()
    {
        Console.WriteLine("Введите количество элементов массива:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        bool isSorted = IsSorted(array);
        Console.WriteLine($"Массив отсортирован по возрастанию: {isSorted}");
    }
}