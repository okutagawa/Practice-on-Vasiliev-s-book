using System;

namespace BookPractice;

// Пример программы на нахождение сотен

class Hundreds
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        int hundreds = a / 100 % 10;

        Console.WriteLine($"В данном числе {hundreds} сотен!");
    }
}