using System;

namespace AddMethod;

public class AddMethod
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int sum = Add(a, b);

        Console.WriteLine(sum);
    }

    static int Add(int a, int b)
    {
        return a + b;
    }

}