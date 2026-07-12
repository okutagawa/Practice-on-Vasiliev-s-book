using System;

namespace GetMinMaxMethod;

public class GetMinMaxMethod
{
    static void GetMinMax(int a, int b, out int min, out int max)
    {
        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }
    }

    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        GetMinMax(a, b, out int min, out int max);

        Console.WriteLine($"Минимум: {min}\nМаксимум: {max}");
    }
}