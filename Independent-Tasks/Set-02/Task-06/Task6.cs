using System;

namespace BookPractice;

// Задание 6. Напишите программу, которая проверяет вторую справа цифру в
// восьмеричном представлении числа, введенного пользователем.
// Число вводится в десятичном (обычном) представлении.

class Task6
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        string octal = Convert.ToString(a, 8);

        int result = Convert.ToInt32(octal);

        result = result / 10 % 10;


        Console.WriteLine($"Второе число в восьмеричном представлении десятичного числа: {result}");
    }
}