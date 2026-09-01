using System;

namespace BookPractice;

class AnotherNestedIf
{
    static void Main()
    {
        Console.Write("Введите целое число: ");
        int n = int.Parse(Console.ReadLine());

        if (n == 1) Console.WriteLine("Единица");
        else if (n == 2) Console.WriteLine("Двойка");
        else if (n == 3) Console.WriteLine("Тройка");
        else if (n == 4) Console.WriteLine("Четверка");
        else if (n == 5) Console.WriteLine("Пятерка");
        else Console.WriteLine("Неизвестное число");
        
    }
}