using System;

namespace SumDigitsMethod;

public class SumDigitsMethod
{
    static void Main()
    {
        int number = SumDigits(123);
    }

    static int SumDigits(int n, int sum = 0)
    {

        if (n == 0)
        {
            return 0;
        }

        sum = n % 10 + SumDigits(n / 10);

        Console.WriteLine(sum);
        return sum;
    }
}