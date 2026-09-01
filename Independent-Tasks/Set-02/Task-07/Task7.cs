using System;

namespace BookPractice;

// Задание 7. Напишите программу, которая вычисляет третий бит справа в двоичном представлении числа, введенного пользователем.
// Число вводится десятичном(обычном) представлении.В программе используйте оператор побитового сдвига.

class Task7
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        int bitPosition = 2;

        int result = (a >> bitPosition) & 1;


        Console.WriteLine($"Третий бит справа в двоичном представлении десятичного числа: {result}");
    }
}