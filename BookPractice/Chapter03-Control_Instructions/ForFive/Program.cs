using System;

namespace BookPractice;

class ForFour
{
    static void Main()
    {
        int n = 10, k = 1, s = 0;

        Console.Write("Сумма 1 + 3 + 5 +...+ {0} = ", 2 * n - 1);

        for (;;)
        {
            s += 2 * k - 1;
            k++;
            if (k > n)
            {
                break;
            }
        }
        Console.WriteLine(s);
    }
}