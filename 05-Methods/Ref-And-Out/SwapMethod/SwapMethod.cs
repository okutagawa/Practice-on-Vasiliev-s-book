using System;

namespace SwapMethod;

public class SwapMethod
{
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a + " " + b);

        Swap(ref a, ref b);
        Console.WriteLine("------------------");
        Console.WriteLine(a + " " + b);
    }
}