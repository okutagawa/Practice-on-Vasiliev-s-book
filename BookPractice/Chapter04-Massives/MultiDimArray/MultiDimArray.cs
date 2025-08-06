using System;

namespace BookPractice;

class MultiDimArray
{
    static void Main()
    {
        // тремерный символьный массив
        char[,,] symbs = new char[4, 3, 5];
        // одномерный символьный массив
        char[] s = { 'б', 'Б', 'b', 'B' };

        // заполнение трехмероного массива и отображение значений его элементов
        
        // Цикл по первому индексу
        for (int i = 0; i < symbs.GetLength(0); i++)
        {
            Console.WriteLine(" Слой № {0}: ", i+1);
            // Цикл по второму индексу
            for (int j = 0; j < symbs.GetLength(1); j++)
            {
                // Цикл по третьему индексу
                for (int k = 0;  k < symbs.GetLength(2); k++)
                {
                    // Присваивание значения элементу массива
                    symbs[i, j, k] = s[i];
                    // Изменение элемента в одномерном массиве
                    s[i]++;
                    // Отображение значения элемента массива
                    Console.Write(symbs[i, j, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
        }
    }
}