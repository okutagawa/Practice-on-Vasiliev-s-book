using System;

namespace RepeatStringMethod;

public class RepeatStringMethod
{
    static void Main()
    {
        string text = Console.ReadLine();
        int times = int.Parse(Console.ReadLine());

        string result = RepeatString(text, times);

        Console.WriteLine(result);
    }

    static string RepeatString(string text, int times)
    {
        string result = "";

        for (int i = 0; i < times; i++)
        {
            result += text;
        }

        return result;
    }

}