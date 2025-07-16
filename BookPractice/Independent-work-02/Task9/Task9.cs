using System;

namespace BookPractice;

// Задание 9. Напишите программу, в которой для введенного пользователем числа
// в бинарном представлении четвертый бит устанавливается равным нулю.

class Task9
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        int bitPosition = 3; 

        int mask = ~(1 << bitPosition);  

        int result = a & mask; 

        Console.WriteLine($"Результат: {result}");
        Console.WriteLine($"В двоичном виде: {Convert.ToString(result, 2)}");
    }
}