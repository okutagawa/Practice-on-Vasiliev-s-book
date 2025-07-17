using System;

namespace BookPractice;

class AnotherSwitch
{
    static void Main()
    {
        Console.Write("Введите целое число от 1 до 9: ");

        int num = int.Parse(Console.ReadLine());

        switch (num)
        {
            case 1:
            case 9:
                Console.WriteLine("Вы ввели нечетное,\n но не простоое число.");
                break;
            case 2:
            case 3:
            case 5:
            case 7:
                Console.WriteLine("Вы ввели простое число.");
                break;
            case 4:
            case 8:
                Console.WriteLine("Вы ввели число - степень двойки");
                break;
            case 6:
                Console.WriteLine("Вы ввели 6 - совершенное число");
                break;
        }
    }
}