using System;
using System.Text;

namespace ConcatMethods;

public class ConcatMethods
{
    static void Main()
    {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        string c = Console.ReadLine();

        string doubleString = Concat(a, b);

        string tripleString = Concat(a, b, c);

        Console.WriteLine(doubleString);
        Console.WriteLine();
        Console.WriteLine(tripleString);
    }   
    
    static string Concat(string a, string b)
    {
        return a + " " + b;
    }

    static string Concat(string a, string b, string c)
    {
        return a + " " + b + " " + c;
    }
}