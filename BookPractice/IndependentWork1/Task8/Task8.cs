using System;

//  Напишите программу для вычисления суммы двух чисел. Оба числа вводятся пользователем. Для вычисления суммы используйте оператор 

class Task8
{
    static void Main()
    {
        Console.Write("Первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сумма введенных чисел составляет: {a+b}");

    }
}