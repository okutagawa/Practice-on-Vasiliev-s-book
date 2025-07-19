using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace BookPractice;

// Задание 6.   Напишите программу, в которой вычисляется сумма нечетных чисел.
// Для проверки результата воспользуйтесь тем,
// что 2 + 4 + 6 + ... + 2n = n(n + 1). Предложите версии программы, использующие разные операторы цикла

class Task6
{
    static void Main()
    {

        int n = 10;
        int k = 1;
        int s = 0;

        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);


        // Решение через while
        while (k <= n)
        {
            s += 2 * k - 1;
            k++;
        }
        Console.WriteLine(s);

        // Решение через do-while
        do
        {
            s += 2 * k - 1;
            k++;
        }
        while (k <= n);
        Console.WriteLine(s);

        // Решение через for 
        for (k = 1; k <= n; k++)
        {
            s += 2 * k - 1;
        }
        Console.WriteLine(s);
    }
}