using System;

namespace PrintNumbersMethod;

public class PrintNumbersMethod
{
    static void Main()
    {
        PrintNumbers(5);
    }

    static void PrintNumbers(int n)
    {
        if (n <= 0)
        {
            return;
        }

        Console.WriteLine(n);

        // n--;

        PrintNumbers(n - 1);

        Console.WriteLine(n);
    }
}