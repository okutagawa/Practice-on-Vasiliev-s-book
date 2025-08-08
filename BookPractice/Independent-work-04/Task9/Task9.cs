using System;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 9. Напишите программу, в которой создается и инициализируется
// двумерный числовой массив. Затем из этого массива удаляется строка и столбец
// (создается новый массив, в котором по сравнению с исходным удалена одна строка и один столбец).
// Индекс удаляемой строки и индекс удаляемого столбца определяется с помощью
// генератора случайных чисел.

class Task9
{
    static void Main()
    {
        Random rnd = new Random();

        //int[,] nums =
        //{
        //    {1,2,3},
        //    {4,5,6},
        //    {7,8,9}
        //};

        int[,] nums = new int[3, 3];

        Console.WriteLine("Исходный двумерный массив размером 3х3: ");
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i, j] = rnd.Next(1,15);
                Console.Write(nums[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine("\n");

        int row = rnd.Next(nums.GetLength(0)); // создаем строку, которая в последствии будет удалена
        int cols = rnd.Next(nums.GetLength(1)); // создаем столбец, который в последствии будет удален

        Console.WriteLine("Удаляется {0}-я строка и {1}-й столбец", row, cols);

        int[,] upd = new int[nums.GetLength(0) - 1, nums.GetLength(1) - 1]; // создаем новый массив уже без 1 строки и 1 столбца.

        int a, b;

        // копирование элементов
        for (int i = 0; i < upd.GetLength(0); i++) 
        {
            if (i < row)
            {
                a = i;
            }
            else
            {
                a = i + 1;
            }
            for (int j = 0; j < upd.GetLength(1); j++)
            {
                if (j < cols)
                {
                    b = j;
                }
                else
                {
                    b = j + 1;
                }
                upd[i, j] = nums[a, b];
            }
        }

        for (int i = 0; i < upd.GetLength(0); i++)
        {
            for (int j = 0; j < upd.GetLength (1); j++)
            {
                Console.Write(upd[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}