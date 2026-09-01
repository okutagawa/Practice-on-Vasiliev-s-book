using System;

namespace BookPractice;

class InitTwoDimArray
{
    static void Main()
    {
        char[,] symbs = { 
            { 'A', 'B', 'C' }, 
            { 'D', 'E', 'F' } 
        };

        Console.WriteLine("Исходный массив: ");

        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                Console.Write(symbs[i, j] + "\t");
            }
            Console.WriteLine();
        }
        // генерирование случ. чисел
        Random rnd = new Random();
        // строка и столбец
        int row = rnd.Next(symbs.GetLength(0) + 1);
        int col = rnd.Next(symbs.GetLength(1) + 1);

        Console.WriteLine("Добавляется {0}-я строка и {1}-й столбец", row, col);

        // Создание нового массива
        char[,] tmp = new char[symbs.GetLength(0) + 1, symbs.GetLength(1) + 1];

        // целочисленные переменные
        int a, b;

        // символьная переменная
        char s = 'a';

        // заполнение массива. копирование значений из исходного массива
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            // первый индекс для элемента нового массива
            if (i < row)
            {
                a = i;
            }
            else
            {
                a = i + 1;
            }

            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                // второй индекс для элемента нового массива
                if (j < col)
                {
                    b = j;
                }
                else
                {
                    b = j + 1;
                }
                // присваивание значения элементу массива
                tmp[a, b] = symbs[i, j];
            }
        }
        // заполнение добавленной строки в новом массиве
        for (int j = 0; j < tmp.GetLength(1); j++)
        {
            // Значение элемента в строке
            tmp[row, j] = s;
            // Новое значение для следующего элемента
            s++;
        }
        for (int i = 0; i < tmp.GetLength(0); i++)
        {
            // если элемент не в добавленной строке
            if (i != row)
            {
                // значение элемента в столбце
                tmp[i, col] = s;
                // новое значение для следующего элемента
                s++;
            }
        }

        // присваивание массивов
        symbs = tmp;
        Console.WriteLine("Новый массив: ");

        // отображение массива
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                Console.Write(symbs[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}