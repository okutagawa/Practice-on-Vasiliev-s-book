using System;

namespace BookPractice;

class For
{
    static void Main()
    {
        int n = 10;

        int k;

        int s = 0;

        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);
        
        for (k = 1; k <= n; k++)
        {
            s += 2 * k - 1;
        }
        Console.WriteLine(s);
    }
}