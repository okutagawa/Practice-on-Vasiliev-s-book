using System;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 5. Напишите программу, в которой создается массив и заполняется случайными числами. Массив отображается в консольном окне.
// В этом массиве необходимо определить элемент с минимальным значением.
// В частности, программа должна вывести значение элемента с минимальным значением
// и индекс этого элемента.Если элементов с минимальным значением несколько,
// должны быть выведены индексы всех этих элементов.

class Task5
{
    static void Main()
    {
        Random rnd = new Random();

        int[] nums = new int[15];

        int value, index;

        Console.WriteLine("Массив из 15 элементов с рандомными числами: ");
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rnd.Next(1, 3);

            Console.Write(nums[i] + " ");
        }
        Console.WriteLine("\n");

        index = 0;
        value = nums[index];

        Console.WriteLine("Минимальный элемент массива: ");
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < value)
            {
                value = nums[i];               
            }
        }
        Console.WriteLine("Наименьшее значение: " + value);
        Console.WriteLine();

        Console.WriteLine("Индекс(-ы) минимального(-ых) значений: ");
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == value)
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }
}