using System;

namespace FibMethod;

public class FibMethod
{
    static void Main()
    {
        Console.Write(Fib(7) + " ");
    } 

    static int Fib(int n)
    {

        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }

        return Fib(n - 1) + Fib(n - 2);
    }
}