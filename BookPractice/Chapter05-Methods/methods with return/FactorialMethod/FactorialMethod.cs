using System;

namespace FactorialMethod;

public class FactorialMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int result = Factorial(a);

        Console.WriteLine(result);
    }

    static int Factorial(int a)
    {
        int result = 1;
        for (int i = 1; i <= a; i++)
        {
            result *= i;
        }

        return result;
    }
}