using System;

namespace SumDigitsMethod;

public class SumDigitsMethod
{
    static void Main()
    {
        Console.WriteLine(SumDigits(123));
    }

    static int SumDigits(int n)
    {

        if (n == 0)
        {
            return 0;
        }
        return n % 10 + SumDigits(n / 10);
    }
}