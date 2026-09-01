using System;

namespace BookPractice;

// Задание 1. Напишите программу, в которой пользователь вводит число,
// а программа проверяет, делится ли это число на 3 и на 7.

class Task1
{
    static void Main()
    {
        Console.Write("Приветик! Введи число, которое делится на 3 и на 7: ");
        int a = int.Parse(Console.ReadLine());

        if (a % 3 == 0 && a % 7 == 0)
        {
            Console.WriteLine("Успех! Вы ввели нужно число!");
        }
        else
        {
            Console.WriteLine("К сожалению, это не то число, которое нам подходит :(");
        }
    }
}