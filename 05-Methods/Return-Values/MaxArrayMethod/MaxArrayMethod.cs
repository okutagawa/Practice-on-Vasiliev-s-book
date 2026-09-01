using System;
using System.Runtime.Serialization.Formatters;

namespace MaxArrayMethod;

public class MaxArrayMethod
{
    static void Main()
    {
        int[] arr = new int[15];

        CreateArray(arr);

        int max = MaxArray(arr);

        Console.WriteLine(max);
    }

    static void CreateArray(int[] arr)
    {
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 20);
        }
    }

    static int MaxArray(int[] arr)
    {
        int max = int.MinValue;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}