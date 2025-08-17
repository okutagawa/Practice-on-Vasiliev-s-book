using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Треугольник Паскаля.

// Даны два числа n и m. Создай двумерный массив A[n, m] и заполни его по следующим правилам:
// 1. Все элементы первой строки(строка с индексом 0) и первого столбца(столбец с индексом 0) равны 1.
// 2. Для всех остальных ячеек значение равно сумме двух соседних элементов: слева и сверху от этой ячейки.


class Task24
{
    public static void Main()
    {
        string a = Console.ReadLine();

        string[] input = a.Split(' '); 

        int n = int.Parse(input[0]); 
        int m = int.Parse(input[1]); 

        int[,] nums = new int[n, m];


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (i == 0 || j == 0)
                {
                    nums[i, j] = 1;
                }
                else
                {
                    nums[i, j] = nums[i,j-1] + nums[i-1, j];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(nums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}