using System;
using System.Reflection;

namespace BookPractice;

// Задание из Stepik Таблица умножения (Пифагора).

// Даны два числа n и m. Создай двумерный массив A[n, m] и
// заполни его таблицей умножения, где i - порядковый номер элемента в строке,
// а j - порядковый номер элемента в столбце.

class Task23
{
    public static void Main()
    {
        string a = Console.ReadLine(); // ввод идет следующий (2 3)

        string[] input = a.Split(' '); // сплитим пробелы

        int n = int.Parse(input[0]); // берем из сплита первый элемент, т.е. 2
        int m = int.Parse(input[1]); // тут второй элемент т.е. 3

        int[,] nums = new int[n, m]; // делаем из данных элементов двумерный массив


        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                nums[i, j] = (i+1) * (j+1); // заполняем используя +1, т.к. индексация идет с 0, поэтому и используем +1
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