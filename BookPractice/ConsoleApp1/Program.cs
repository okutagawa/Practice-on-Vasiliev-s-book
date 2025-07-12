using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Знакомство в консоли";

            string name;

            Console.WriteLine("Привет, как тебя зовут?");

            name = Console.ReadLine();

            Console.WriteLine($"Приятно познакомиться, {name}!");
            Console.WriteLine("Знакомство состоялось!");
        }
    }
}