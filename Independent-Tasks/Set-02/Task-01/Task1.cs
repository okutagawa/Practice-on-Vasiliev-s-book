using System;

namespace BookPractice;

// Задание 1. Напишите программу, которая проверяет, делится ли введенное пользователем число на 3.

class Task1
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        string result = (a % 3 == 0) ? "делится" : "не делится";

        Console.WriteLine($"Вы ввели число, которое {result} на 3!!!");
    }
}