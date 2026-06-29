using System;

namespace IsPositiveMethod;

public class IsPositiveMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        bool isPositive = IsPositive(a);

        Console.WriteLine(isPositive);

    }

    static bool IsPositive(int a)
    {
        return a > 0 ? true : false;
    }

}