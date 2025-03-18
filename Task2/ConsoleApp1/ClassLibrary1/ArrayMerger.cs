using System;
using System.Linq;

namespace ClassLibrary1
{
    public static class ArrayMerger
{
    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        if (array1 == null | array2 == null)
            throw new ArgumentNullException("Ошибка: один из массивов равен null.");
        if (array1.Length == 0 | array2.Length == 0)
            throw new ArgumentException("Ошибка: один из массивов пуст.");

        //int[] merged = new int[array1.Length + array2.Length];
        return    array1.Concat(array2).ToArray();
            
        //Array.Copy(array1, merged, array1.Length);
        //Array.Copy(array2, 0, merged, array1.Length, array2.Length);
        //    return merged;
        }
    }
}