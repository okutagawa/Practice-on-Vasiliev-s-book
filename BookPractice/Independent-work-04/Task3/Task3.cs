using System;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 3. Напишите программу, в которой создается одномерный символьный
// массив из 10 элементов.Массив заполняется буквами «через одну», начиная с буквы 'a':
// то есть массив заполняется буквами 'a', 'c', 'e', 'g' и так далее.
// Отобразите массив в консольном окне в прямом и обратном порядке.
// Размер массива задается переменной.

class Task3
{
    static void Main()
    {
        char s = 'a';
        int a = 10;
        char[] symbs = new char[a];

        Console.WriteLine("Символьный массив из 10 символов идущие через одну букву: ");
        for (int i = 0; i < symbs.Length; i++)
        {
            symbs[i] = s;
            Console.Write("| " + symbs[i] + " ");
            s = (char)(s + 2);
        }
        Console.WriteLine("|\n");

        Console.WriteLine("Тот же массив, но обратный: ");
        for (int i = symbs.Length - 1; i >= 0; i--)
        {
            Console.Write("| " + symbs[i] + " ");
        }
        Console.WriteLine("|");
    }
}