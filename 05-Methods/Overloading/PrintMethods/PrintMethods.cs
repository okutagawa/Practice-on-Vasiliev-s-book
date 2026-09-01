using System;

namespace PrintMethods;

public class PrintMethods
{
    static void Main()
    {
        string text = Console.ReadLine();

        int number = int.Parse(Console.ReadLine());

        Print(text);
        Print(number);
        Print(text, number);

    }  

    static void Print(string text)
    {
        Console.WriteLine(text);
    }

    static void Print(int number)
    {
        Console.WriteLine(number);
    }

    static void Print(string text, int number)
    {
        Console.WriteLine("Текст: " + text + ", Число: " + number);
    }
}