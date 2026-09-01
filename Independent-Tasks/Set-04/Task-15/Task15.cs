using System;
using System.Reflection;


namespace BookPractice;

// Задание из Stepik Однополярные соседи. 
// Дан массив целых чисел.Напиши программу, которая проверит,
// есть ли в массиве пара соседних элементов с одинаковыми знаками
// (оба положительные или оба отрицательные). Если в массиве найдётся хотя бы одна
// пара соседних элементов с одинаковыми знаками,
// программа должна вывести сообщение YES, в противном случае — NO.

class Task15
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
        int canceledCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (i + 1 < nums.Length)
            {
                if (nums[i] >= 0 && nums[i + 1] >= 0)
                {
                    count++;
                }
                else if (nums[i] < 0 && nums[i + 1] < 0)
                {
                    count++;
                }
                else if (nums[i] >= 0 && nums[i + 1] <= 0 || nums[i] < 0 && nums[i + 1] >= 0)
                {
                    canceledCount++;
                }
            }
        }

        if (count > 0 || count > canceledCount)
        {
            Console.WriteLine("YES");
        }
        else if (canceledCount > 0 && count == 0) 
        {
            Console.WriteLine("NO");
        }
    }
}