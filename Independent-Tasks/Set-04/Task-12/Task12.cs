using System;
using System.Reflection;

namespace BookPracitce;

// Задание из Stepik Поиск-2.

// Дан массив целых чисел. Напиши программу, которая выведет те элементы массива, значения которых делятся на 3.

class Task12
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();

        int[] nums = new int[n];

        string[] numbers = a.Split(' ');

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }

        for (int i = 0; i < n; i++)
        {
            if (nums[i] % 3 == 0)
            {
                Console.Write(nums[i] + " "); // здесь всё тоже самое что и в задании Поиск-1 (Task11), только на вывод подаем элементы массива кратные трем. 
            }
        }
        Console.WriteLine();
    }
}