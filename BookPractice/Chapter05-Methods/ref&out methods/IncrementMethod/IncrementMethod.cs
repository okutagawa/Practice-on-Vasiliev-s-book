using System;

namespace IncrementMethod;

public class IncrementMethod
{
    static void ChangeValue(ref int number)
    {
        number++;
    }

    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine(num);

        ChangeValue(ref num);

        Console.WriteLine(num);
    }
}