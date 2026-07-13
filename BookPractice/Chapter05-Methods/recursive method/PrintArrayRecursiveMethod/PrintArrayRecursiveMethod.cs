using System;

namespace PrintArrayRecursiveMethod;

public class PrintArrayRecursiveMethod
{
    static void Main()
    {
        int[] arr = new int[15];
        int index = 0;
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 25);
        }

        PrintArrayRecursive(arr, index);
    }
    
    static void PrintArrayRecursive(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            return;
        }

        Console.WriteLine(arr[index]);
        index++;
        PrintArrayRecursive(arr, index);
    }
}