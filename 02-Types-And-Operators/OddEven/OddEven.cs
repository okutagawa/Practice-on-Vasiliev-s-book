using System;

namespace BookPractice;

// Пример программы на нахождение четного или нечетного числа

class OddEven
{
    static void Main()
    {
        Console.Write("Введите желаемое число: ");
        int a = int.Parse(Console.ReadLine());

        string result = (a % 2 == 0) ? "четное" : "нечетное";

        Console.WriteLine($"Вы ввели {result} число!");
     }
}