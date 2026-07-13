using System;

namespace FibMethod;

public class FibMethod
{
    static void Main()
    {
        int n = Fib(7);
    } 

    static int Fib(int n)
    {
        // int result;
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }

        // result = Fib(n - 1) + Fib(n - 2);

        Console.Write(Fib(n - 1) + Fib(n - 2) + ", ");

        return n;
    }
}