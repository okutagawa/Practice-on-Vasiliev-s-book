using System;

namespace TryParseIntMethod;

public class TryParseIntMethod
{
    static void Main()
    {
        string input = Console.ReadLine();

        TryParse(input, out int result);

        Console.WriteLine(result);
    }   

    static void TryParse(string text, out int result)
    {
        result = int.Parse(text);
    }
}