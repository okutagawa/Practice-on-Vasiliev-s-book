using System;

namespace BookPractice;

class TwoDimArray
{
    static void Main()
    {
        // кол-во строк и столбцов в массиве
        int row = 3, cols = 5;

        // создание двумерного массива
        int[,] nums = new int[row, cols];

        // значение первого элемента в массиве
        int value = 1;

        // заполнение и отображение массива. Перебор строк в массиве

        for (int i = 0; i < nums.GetLength(0); i++)
        {
            // перебор столбцов в строке
            for (int j = 0; j < nums.GetLength(1); j++)
            {
                // присваивание значения элементу массива
                nums[i, j] = value;
                // это будет значение след. элемента
                value++;
                // отображение элемента в строке
                Console.Write(nums[i, j] + "\t");
            }
            // переход к новой строке
            Console.WriteLine();
        }
    }
}