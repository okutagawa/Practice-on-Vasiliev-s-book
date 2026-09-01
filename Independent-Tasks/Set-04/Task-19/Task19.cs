using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Палиндром.

// Дан массив целых чисел. Напиши программу, которая определяет,
// является ли массив палиндромом. Если массив является палиндромом,
// программа должна вывести сообщение YES, в противном случае — NO.

class Task19
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string a = Console.ReadLine();

        int[] nums = new int[n];
        int[] nums2 = new int[n];

        string[] numbers = a.Split(' ');

        for (int i = 0; i < n; i++)
        {
            nums2[i] = int.Parse(numbers[i]);
            nums[i] = int.Parse(numbers[i]);
        }

        for (int i = 0; i < nums.Length / 2; i++)
        {
            int s = nums[i]; // присваиваем запасной переменной значение первого индекса
            nums[i] = nums[nums.Length - 1 - i]; // исходному значению индекса присваиваем последний индекс - i 
            nums[nums.Length - 1 - i] = s; // последнему индексу присваиваем значение первого индекса из запасной переменной
        }

        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == nums2[i])
            {
                count++;
            }
        }

        if (count == nums.Length)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}