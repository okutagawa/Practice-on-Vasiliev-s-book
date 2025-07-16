using System;

namespace BookPractice;

// Задание 8. Напишите программу, в которой для введенного пользователем числа
// в бинарном представлении третий бит устанавливается равным единице.

class Task8
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        int bitPosition = 2;

        int mask = 1 << bitPosition;

        int result = a | mask;


        Console.WriteLine($"Результат: {result}");
    }
}