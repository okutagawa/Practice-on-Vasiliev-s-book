using System;
using System.Diagnostics.SymbolStore;

namespace BookPractice;

// Задание 4. Напишите программу, в которой создается символьный массив
// из 10 элементов.Массив заполнить большими(прописными) буквами английского алфавита.
// Буквы берутся подряд, но только согласные(то есть гласные буквы 'A','E' и 'I'
// при присваивании значений элементам массива нужно пропустить).
// Отобразите содержимое созданного массива в консольном окне.

class Task4
{
    static void Main()
    {
        char[] symbs = new char[10];
        char s = 'A';

        int count = 0;

        while(count < 10)
        {
            symbs[count] = s;

            if (symbs[count] != 'A' && symbs[count] != 'E' && symbs[count] != 'I')
            {
                Console.Write(symbs[count] + " ");
                count++;
            }
            s++;
        }
    }
}