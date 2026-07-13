using System;
using System.Diagnostics.CodeAnalysis;

namespace PowerRecMethod;

public class PowerRecMethod
{
    static void Main()
    {
        int baseNum = int.Parse(Console.ReadLine());

        int exponent = int.Parse(Console.ReadLine());

        int result = PowerRec(baseNum, exponent);

        Console.WriteLine(result);
    }

    static int PowerRec(int baseNum, int exponent)
    {
        if (exponent == 0)
        {
            return 1;
        }

        return baseNum = baseNum * PowerRec(baseNum, exponent - 1);
    }
}