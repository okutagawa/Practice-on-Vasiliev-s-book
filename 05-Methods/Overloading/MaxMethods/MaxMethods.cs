using System;

namespace MaxMethods;

public class MaxMethods
{
    static void Main()
    {
        Console.WriteLine("Введите три числа");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int firstMax = Max(a, b);
        int secondMax = Max(a, b, c);

        SelectOption(firstMax, secondMax);
    }

    static void SelectOption(int firstMax, int secondMax)
    {
        Console.WriteLine("Введите желаемую операцию: ");
        Console.WriteLine("1. Вывести максимум из первых двух чисел");
        Console.WriteLine("2. Вывести максимум из трех чисел");

        char firstOption = '1';
        char secondOption = '2';

        char writeOption = char.Parse(Console.ReadLine());

        if (writeOption == firstOption)
        {
            Console.WriteLine("Максимум из двух чисел: " + firstMax);
        }
        else
        {
            Console.WriteLine("Максимум из трех чисел: " + secondMax);
        }
    }

    static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    static int Max(int a, int b, int c) 
    {
        if (a > b && a > c)
        {
            return a;
        }
        else if (b > c)
        {
            return b;
        }
        else
        {
            return c;
        }
    }
}