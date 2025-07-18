using System;

namespace BookPractice;

class AnotherWhile
{
    static void Main()
    {
        int n = 10;
        int k = 1;
        int s = 0;

        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

        do
        {
            s += 2 * k - 1;
            k++;
        }
        while (k <= n);
        Console.WriteLine(s);
    }
}