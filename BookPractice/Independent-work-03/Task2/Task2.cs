using System;

namespace BookPractice;

// Задание 2. Напишите программу, в которой пользователь последовательно вводит два целых числа.
// Программа определяет, какое из чисел больше или
// они равны, и выводит сообщение в диалоговом окне.

class Task2
{
    static void Main()
    {
        Console.WriteLine("Приветик! Введи последовательно два целых числа!");
        Console.Write("Первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Второе число: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            Console.WriteLine($"Число {a} больше чем число {b}!");
        }
        else if(a < b)
        {
            Console.WriteLine($"Число {b} больше чем число {a}!");
        }
        else
        {
            Console.WriteLine($"Число {a} равно числу {b}!!!");
        }
    }
}