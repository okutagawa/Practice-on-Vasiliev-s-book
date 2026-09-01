using System;

namespace BookPractice;

class AnotherWhile
{
    static void Main()
    {
        int n = 10;

        int s = 0;

        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

        while (n>0)
        {
            s += 2 * n - 1;
            n--;
        }
        Console.WriteLine(s);
    }
}