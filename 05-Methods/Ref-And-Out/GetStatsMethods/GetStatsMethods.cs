using System;

namespace GetStatsMethods;

public class GetStatsMethods
{
    static void Main()
    {
        int[] arr = new int[15];

        FillArrayAndGetStats(arr, out int min, out int max);

        PrintArray(arr);
        Console.WriteLine();
        Console.WriteLine($"Максимум массива: {max}\nМинимум массива: {min}");

        GetArrayStats(arr, out int sum, out int average);
        Console.WriteLine();
        Console.WriteLine($"Сумма элементов массива: {sum}\nСреднее арифметическое массива: {average}");
    }

    static void FillArrayAndGetStats(int[] arr, out int min, out int max)
    {
        Random rnd = new Random();
        min = int.MaxValue;
        max = int.MinValue;

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            arr[i] = rnd.Next(1, 25);

            if (arr[i] > max)
            {
                max = arr[i];
            }
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
    }

    static void GetArrayStats(int[] arr, out int sum, out int average)
    {
        sum = 0;
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            sum += arr[i];
        }
        average = sum / arr.Length;
    }

    static void PrintArray(int[] arr)
    {
        for (int i = 0; i <= arr.Length - 1; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}