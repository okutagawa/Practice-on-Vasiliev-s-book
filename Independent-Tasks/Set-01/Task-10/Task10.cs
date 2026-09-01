using System;

//Напишите программу, в которой пользователь вводит два числа, а программой вычисляется и отображается сумма и разность этих чиселclass Task10

class Task10
{
    static void Main()
    {
        Console.Write("Первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сумма введенных чисел составляет: {a + b}");
        Console.WriteLine($"Разность введенных чисел составляет: {a - b}");
    }
}