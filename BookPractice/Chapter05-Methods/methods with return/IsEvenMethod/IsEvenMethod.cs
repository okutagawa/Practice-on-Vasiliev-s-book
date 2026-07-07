using System;

namespace IsEvenMethod;

public class IsEvenMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        bool isEven = IsEven(a);

        Console.WriteLine(isEven);

    }

    static bool IsEven(int a)
    {
        return a % 2 == 0 ? true : false;
    }

}