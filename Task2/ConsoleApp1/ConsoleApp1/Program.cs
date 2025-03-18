using System;
using ClassLibrary1;
using static ClassLibrary1.ArrayMerger;
public class Program
{
    public static void Main(string[] args)
    {
        //Console.Write("Введите количество элементов первого массива: ");
        //int n1 = int.Parse(Console.ReadLine());

        //int[] array1 = new int[n1];

        //for (int i = 0; i < n1; i++)
        //{
        //    Console.Write($"Введите элемент {i + 1} первого массива: ");
        //    array1[i] = int.Parse(Console.ReadLine());
        //}

        //Console.Write("Введите количество элементов второго массива: ");
        //int n2 = int.Parse(Console.ReadLine());

        //int[] array2 = new int[n2];

        //for (int i = 0; i < n2; i++)
        //{
        //    Console.Write($"Введите элемент {i + 1} второго массива: ");
        //    array2[i] = int.Parse(Console.ReadLine());
        //}

        int[] array1 = Enumerable.Range(1, Random.Shared.Next(5, 10)).ToArray();
            Random.Shared.Shuffle(array1);
        int[] array2 = Enumerable.Range(1, Random.Shared.Next(5, 10)).ToArray();
        Random.Shared.Shuffle(array2);
        Console.WriteLine("Элементы первого массива: " + string.Join(", ", array1));
        Console.WriteLine("Элементы второго массива: " + string.Join(", ", array2));

        try
        {

            int[] mergedArray = MergeArrays(array1, array2);
            Console.WriteLine("Объединенный массив: " + string.Join(", ", mergedArray));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }  
}