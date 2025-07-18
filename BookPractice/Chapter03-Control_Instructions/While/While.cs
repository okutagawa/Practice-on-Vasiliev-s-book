using System;

namespace BookPractice;

class While
{
    static void Main()
    {
        int n = 10;

        int k = 1;

        int s = 0;

        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

        while (k<=n)
        {
            s += 2 * k - 1;
            k++;
        }
        Console.WriteLine(s);
    }
}