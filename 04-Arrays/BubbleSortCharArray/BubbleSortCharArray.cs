using System;

namespace BookPractice;

class BubbleSortCharArray
{
    static void Main()
    {
        char s;
        char[] symbs = { 'Q', 'Ы', 'a', 'B', 'R', 'A', 'r', 'q', 'b' };

        Console.WriteLine("Массив до сортировки: ");

        for (int i = 0; i < symbs.Length; i++)
        {
            Console.Write(symbs[i] + " ");
        }
        Console.WriteLine();

        // Сортировка элементов в массиве с помощью пузырькового метода,
        for (int i = 1; i < symbs.Length; i++)
        {
            // Перебор элементов
            for (int j = 0; j < symbs.Length - 1; j++)
            {
                // Если значение элемента слева больше значения эл. справа: 
                if (symbs[j] > symbs[j+1])
                {
                    s = symbs[j+1];
                    symbs[j+1] = symbs[j];
                    symbs[j] = s;
                }
            }
        }
        Console.WriteLine("Массив после сортировки: ");
        for (int k = 0; k < symbs.Length; k++)
        {
            Console.Write(symbs[k] + " ");
        }
    }
}