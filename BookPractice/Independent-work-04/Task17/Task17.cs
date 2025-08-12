using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Индекс минимального элемента.

// Дан массив целых чисел.Напиши программу, которая находит индекс минимального
// элемента массива. Индексация начинается с нуля.

class Task17
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

        int min = nums[0]; // объявляем минимум и задаем так что минимум это у нас уже первое число массива
        int index = 0; // индекс соответствующий положению минимума
         
        for (int i = 1; i < nums.Length; i++) // начинаем сравнивать со второго индекса массива
        {
            if (nums[i] < min)
            {
                min = nums[i]; // обновляем минимум
                index = i; // обновляем индекс если нашли минимум
            }
        }
        Console.WriteLine(index);
    }
}