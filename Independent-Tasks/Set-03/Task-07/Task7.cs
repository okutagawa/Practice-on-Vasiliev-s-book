using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace BookPractice;

// Задание 7. Напишите программу для вычисления суммы квадратов
// натуральных чисел. Предложите версии программы, использующие разные
// операторы цикла.

class Task7
{
    static void Main()
    {

        int n = 10;
        int k = 1;
        int s = 0;

        Console.Write("Сумма квадратов 1^2 + 2^2 + 3^2 +...+ {0}^2 = ", n);


        // Решение через while
        while (k <= n)
        {
            s += k * k;
            k++;
        }
        Console.WriteLine(s);


        // Решение через do-while 
        do
        {
            s += k * k;
            k++;
        }
        while (k <= n);
        Console.WriteLine(s);


        // Решение через for 
        for (k = 1; k <= n; k++) 
        {
            s += k * k;
        }
        Console.WriteLine(s);
    }
}