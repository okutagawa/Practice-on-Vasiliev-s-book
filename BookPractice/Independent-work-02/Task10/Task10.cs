using System;

namespace BookPractice;

// Задание 10. Напишите программу, в которой для введенного пользователем числа
// в бинарном представлении значение второго бита меняется на противоположное
// (исходное нулевое значение бита меняется на единичное, а исходное единичное значение бита меняется на нулевое).

class Task10
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        int bitPosition = 1;

        int mask = 1 << bitPosition;

        int result = a ^ mask;

        Console.WriteLine($"Исходное: {Convert.ToString(a, 2)}");
        Console.WriteLine($"Результат: {Convert.ToString(result, 2)}");
    }
}