using System;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 10. Напишите программу, в которой создается двумерный числовой массив
// и этот массив заполняется «змейкой»: сначала первая строка (слева направо),
// затем последний столбец (сверху вниз), последняя строка (справа налево),
// первый столбец(снизу вверх), вторая строка(слева направо) и так далее.

class Task10
{
    static void Main()
    {
        Random rnd = new Random();

        int row = 16, cols = 16;

        int top = 0;
        int bottom = row - 1;
        int left = 0;
        int right = cols - 1;

        int[,] nums = new int[row, cols];

        while (top <= bottom && left <= right)
        {
            // верхняя строка (слева направо)
            for (int j = left;  j <= right; j++)
            {
                nums[top, j] = rnd.Next(1, 10); 
            }
            top++; // сдвигаем верхнюю границу

            // первый столбец (сверху вниз)
            for (int i = top; i <= bottom; i++)
            {
                nums[i, right] = rnd.Next(1, 10);
            }
            right--; // сдвигаем первую границу

            // нижняя строка (справа налево)
            for (int j = right; j >= left; j--)
            {
                nums[bottom, j] = rnd.Next(1, 10);
            }
            bottom--; // сдвигаем нижнюю границу

            // левый столбец (снизу вверх)
            for (int i =  bottom; i >= top; i--)
            {
                nums[i, left] = rnd.Next(1, 10);
            }
            left++; // сдвигаем левую границу
        }

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                Console.Write(nums[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}