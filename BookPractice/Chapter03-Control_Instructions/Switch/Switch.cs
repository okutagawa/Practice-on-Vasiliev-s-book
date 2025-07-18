using System;

namespace BookPractice;

class Switch
{
    static void Main()
    {
        Console.Write("Введите число: ");

        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
                Console.WriteLine("Единица");
                break;
            case 2:
                Console.WriteLine("Двойка");
                break;
            case 3:
                Console.WriteLine("Тройка");
                break;
            case 4:
                Console.WriteLine("Четверка");
                break;
            case 5:
                Console.WriteLine("Пятерка");
                break;
            default:
                Console.WriteLine("Неизвестное число");
                break;
        }
    }
}