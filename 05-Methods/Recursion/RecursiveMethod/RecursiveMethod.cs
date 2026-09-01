using System;

namespace RecursiveMethod;

public class RecursiveMethod
{
    static void Foo(int a)
    {
        Console.WriteLine(a);

        if (a >= 3)
        {
            return;
        }


        a++;
        Foo(a);
    }

    static void Main()
    {
        Foo(0);
    }

}