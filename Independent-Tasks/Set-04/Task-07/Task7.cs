using System;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 7. Напишите программу, в которой создается символьный массив,
// а затем порядок элементов в массиве меняется на обратный.

class Task7
{
    static void Main()
    {
        Random rnd = new Random();

        char[] symbs = new char[15];


        Console.WriteLine("Отображение символьного массива из рандомных заглавных букв: ");
        for (int i = 0; i < symbs.Length; i++)
        {
            symbs[i] = (char)rnd.Next(65,91);
            Console.Write("| " +  symbs[i] + " ");
        }
        Console.WriteLine("|\n");

        // сортировка массива в обратном порядке
        for (int i = 0; i < symbs.Length / 2; i++)
        {
            char s = symbs[i]; // присваиваем запасной переменной значение первого индекса
            symbs[i] = symbs[symbs.Length - 1 - i]; // исходному значению индекса присваиваем последний индекс - i 
            symbs[symbs.Length - 1 - i] = s; // последнему индексу присваиваем значение первого индекса из запасной переменной
        }

        Console.WriteLine("Тот же массив, но в обратном порядке: ");
        for (int i = 0; i < symbs.Length; i++)
        {
            Console.Write("| " + symbs[i] + " ");
        }
        Console.WriteLine("|\n");
    }
}