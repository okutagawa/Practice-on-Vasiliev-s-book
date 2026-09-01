using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Палиндром.

// Дан массив целых чисел. Напиши программу, которая определяет,
// является ли массив палиндромом. Если массив является палиндромом,
// программа должна вывести сообщение YES, в противном случае — NO.

class Task20
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

        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            count = 0;

            for (int j = 0; j < n; j++)
            {
                if (nums[j] == nums[i])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}