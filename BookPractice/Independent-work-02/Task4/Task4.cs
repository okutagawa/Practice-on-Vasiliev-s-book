using System;

namespace BookPractice;

// Задание 4. Напишите программу, которая проверяет, попадает ли введенное
// пользователем число в диапазон от 5 до 10 включительно.

class Task4
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        string result = (a >= 5 && a <= 10) ? "соответствует" : "не соответствует";

        Console.WriteLine($"Число введенное пользователем {result} требованиям!");
    }
}