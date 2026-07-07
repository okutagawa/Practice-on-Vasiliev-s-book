using System;

namespace SumArrayMethod;

public class SumArrayMethod
{
    static void Main()
    {
        int[] arr = new int[15];

        CreateArray(arr);

        int sum = SumArray(arr);

        Console.WriteLine(sum);
    }

    static void CreateArray(int[] arr)
    {
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 20);
        }
    }

    static int SumArray(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }
}