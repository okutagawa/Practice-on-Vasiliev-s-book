using System;

namespace MultiplyDoubleMethod;

public class MultiplyDoubleMethod
{
    static void Main()
    {
        double value = double.Parse(Console.ReadLine());

        MultiplyDouble(ref value);

        Console.WriteLine(value);
    }

    static void MultiplyDouble(ref double value)
    {
        value *= 2;
    }
}