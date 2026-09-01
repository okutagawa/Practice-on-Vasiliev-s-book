using System;
using System.ComponentModel;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 8. Напишите программу, в которой создается двумерный целочисленный массив.
// Он заполняется случайными числами. Затем в этом массиве строки и столбцы
// меняются местами: первая строка становится первым столбцом, вторая строка становится
// вторым столбцом и так далее.Например, если исходный массив состоял из 3 строк и 5 столбцов,
// то в итоге получаем массив из 5 строк и 3 столбцов.

class Task8
{
    static void Main()
    {
        Random rnd = new Random();

        int row = 8, cols = 3;

        int[,] nums = new int[row,cols];

        Console.WriteLine("Исходный двумерный массив: ");
        for (int i = 0; i < nums.GetLength(0); i++)
        {
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                nums[i,j] = rnd.Next(1, 101);
                Console.Write(nums[i,j] + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        int[,] n = new int[cols, row]; // задаем новый массив, только уже со значениями колонка/строка

        Console.WriteLine("Тот же массив, только теперь строка это столбец, а столбец это строка: ");
        for (int i = 0; i < nums.GetLength(1); i++) // начинаем итерацию с колонки то есть GetLength(1)
        {
            for (int j = 0; j < nums.GetLength(0); j++) // внутренний цикл начинаем с GetLength(0) т.к. смотрим вторым делом строки
            {
                n[i, j] = nums[j, i]; // Присваиваем новому массиву перевернутый исходный массив где первая j, а вторая i из прошлого цикла
                Console.Write(n[i, j] + "\t");  // виводим :)
            }
            Console.WriteLine();
        }
    }
}