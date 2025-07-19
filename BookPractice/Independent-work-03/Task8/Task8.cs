using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace BookPractice;

// Задание 8. Напишите программу, которая выводит последовательность чисел
// Фибоначчи.Первые два числа в этой последовательности равны 1,
// а каждое следующее число равно сумме двух предыдущих
// (получается последовательность 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 и так далее).
// Количество чисел в последовательности вводится пользователем.Предложите
// версии программы, использующие разные операторы цикла.

class Task8
{
    static void Main()
    {
        Console.Write("Введите число для последовательности Фибоначии: ");
        int n = int.Parse(Console.ReadLine());
        int a = 1, b = 1;
        int count = 2;
        int next;

        if (n == 1)
        {
            Console.Write(a);
        }
        else if (n >= 2)
        {
            Console.Write(a + " " + b);

            // Решение через while
            while (count < n)
            {
                next = a + b;
                Console.Write(" " + next);
                a = b; b = next;
                count++;
            }

            // Решение через do-while
            do
            {
                next = a + b;
                Console.Write(" " + next);
                a = b; b = next;
                count++;
            }
            while (count < n);
            
            // Решение через for 
            for (count = 2; count < n; count++)
            {
                next = a + b;
                Console.Write(" " + next);
                a = b; b = next;
            }
        }
        else
        {
            Console.Write("Введите число!");
        }
    }
}