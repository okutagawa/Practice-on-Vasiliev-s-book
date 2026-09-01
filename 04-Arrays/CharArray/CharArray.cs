using System;

namespace BookPractice;

class CharArray
{
    static void Main()
    {
        Random rnd = new Random(); // объект для генерации случайных чисел

        int size = 10, k; // Размер массива и индексная переменная

        char[] symb = new char[size];

        Console.WriteLine("Массив случайных символов: ");

        for (k = 0; k < symb.Length; k++)
        {
            // значение элемента массива
            symb[k] = (char) ('A' + rnd.Next(26));

            Console.Write("| " +  symb[k] + " ");
        }
        Console.WriteLine("|");

        Console.WriteLine("Массив в обратном порядке: ");

        for (k = symb.Length - 1; k >= 0; k--)
        {
            Console.Write("| " + symb[k] + " ");
        }
        Console.WriteLine("|");
    }
}