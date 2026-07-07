using System;

namespace PowerMethods;

public class PowerMethods
{
    static void Main()
    {
        Console.WriteLine("Введите число и экспоненту.");
        int num = int.Parse(Console.ReadLine());
        int exponent = int.Parse(Console.ReadLine());

        int squareNum = Power(num);
        int cosmicSquareNum = Power(num, exponent);

        Console.WriteLine($"Число {num} во второй степени =  " + squareNum);

        Console.WriteLine($"Число {num} в степени {exponent} = " + cosmicSquareNum);
    }

    static int Power(int num)
    {
        return num * num;
    }

    static int Power(int num, int exponent)
    {
        int result = 1;
        for (int i = 1; i <= exponent; i++) 
        {
            result *= num;
        }

        return result;
    }
}