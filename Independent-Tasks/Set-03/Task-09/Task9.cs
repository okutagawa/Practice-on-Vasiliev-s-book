using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;

namespace BookPractice;

// Задание 9. Напишите программу, в которой пользователем вводится два целых
// числа.Программа выводит все целые числа — начиная с наименьшего
// (из двух введенных чисел) и заканчивая наибольшим(из двух введенных чисел).
// Предложите разные версии программы(с использованием разных операторов цикла),
// а также механизм обработки исключений для этой программы.

class Task9
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        int count = 0;
        int s = 0;

        if (a > b)
        {
            // Решение через while

            while (b <= a)
            {
                s = b;
                b += 1;
                Console.Write(s + " ");
                count++;
            }


            // Решение через for

            for (count = 0; b <= a; count++)
            {
                s = b;
                b += 1;
                Console.Write(s + " ");
            }
        }
        else if (a < b)
        {
            // Решение через while

            while (a <= b)
            {
                s = a;
                a += 1;
                Console.Write(s + " ");
                count++;
            }


            // Решение через for

            for (count = 0; a <= b; count++)
            {
                s = a;
                a += 1;
                Console.Write(s + " ");
            }
        }
        else
        {
            Console.WriteLine("Введите число!");
        }
    }
}