using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Побочная диагональ.

// Дано число n (n ≤ 100). Создай квадратный массив n × n и заполни его по правилу:

// 1. Элементы на побочной диагонали(идущей из правого верхнего угла в левый нижний) равны 1;
// 2. Элементы выше этой диагонали — 0;
// 3. Элементы ниже этой диагонали — 2.

class Task21
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] nums = new int[n,n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i + j  + 1 == n) // Для побочной диагонали сумма индексов i (строка) и j (столбец) всегда равна n - 1.
                {
                    nums[i,j] = 1;
                }
                else if (i > n - 1 - j) // Ниже диагонали: i + j > n - 1 (ближе к левому нижнему углу)
                {
                    nums[i,j] = 2;
                }
                Console.Write(nums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}