using System;

namespace BookPractice;

class UsingIf
{
    static void Main()
    {
        Console.WriteLine("Привет, давай познакомимися! Как тебя зовут?");
        string name = Console.ReadLine();

        if (name == "")
        {
            Console.WriteLine("Очень жаль, что мы так и не познакомились(");
        }
        else
        {
            Console.WriteLine($"Очень приятно, {name}, я рад знакомству!");
        }
    }
}