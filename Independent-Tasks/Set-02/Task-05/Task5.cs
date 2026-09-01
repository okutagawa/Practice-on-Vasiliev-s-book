using System;

namespace BookPractice;

// Задание 5. Напишите программу, которая проверяет,
// сколько тысяч во введенном пользователем числе
// (определяется четвертая цифра справа в десятичном представлении числа).

class Task5
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        int result = a / 100 / 10 % 10;

        Console.WriteLine($"В вашем числе {result} тысячных!");
    }
}