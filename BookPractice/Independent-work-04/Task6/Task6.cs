using System;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 6. Напишите программу, в которой создается целочисленный массив,
// заполняется случайными числами и после этого значения элементов
// в массиве сортируются в порядке убывания значений.

class Task6
{
    static void Main()
    {
        Random rnd = new Random();

        int[] nums = new int[20];

        int s;

        Console.WriteLine("Массив из рандомных чисел: ");
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(1, 101);
            Console.Write("| " + nums[i] + " ");
        }
        Console.WriteLine("|\n");

        // Пузырьковая сортировка
        for (int i = 1;  i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - 1; j++)
            {
                if (nums[j] >  nums[j + 1])
                {
                    s = nums[j + 1];
                    nums[j+1] = nums[j];
                    nums[j] = s;
                }
            }
        }

        Console.WriteLine("Отсортированный массив с помощью пузырька: ");
        for (int k = 0; k < nums.Length; k++)
        {
            Console.Write("| " + nums[k] + " ");
        }
        Console.WriteLine("|\n");

        Console.WriteLine("Отсортированный массив в обратном порядке: ");
        for (int k = nums.Length - 1; k >= 0; k--)
        {
            Console.Write("| " + nums[k] + " ");
        }
        Console.WriteLine("|\n");
    }
}