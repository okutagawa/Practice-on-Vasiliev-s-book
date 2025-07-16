using System;

namespace BookPractice;

// Задание 3. Напишите программу, которая проверяет, удовлетворяет ли введенное пользователем число следующим критериям: число делится на 4,
// и при этом оно не меньше 10.

class Task3
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        string result = (a % 4 == 0 && a >= 10) ? "соответствует" : "не соответствует";

        Console.WriteLine($"Число введенное пользователем {result} требованиям!");
    }
}