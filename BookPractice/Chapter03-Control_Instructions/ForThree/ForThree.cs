using System;

namespace BookPractice;

class ForThree
{
    static void Main()
    {
        int n = 10, k, s;

        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

        for (k = 1, s = 0; k <= n; s += 2 * k - 1, k++);
        Console.WriteLine(s);
    }
}