using System;

namespace Multiply;

public class MultiplyMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int mult = Multiply(a, b);

        Console.WriteLine(mult);
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

}