using System;

namespace BookPractice;

class NestedIf
{
    static void Main()
    {
        Console.Write("Введите текст: ");

        string txt = Console.ReadLine();

        if (txt != "")
        {
            Console.WriteLine("Спасибо, что ввели текст!");

            if (txt.Length > 10)
            {
                Console.WriteLine("Ого, как много букв!!!");
            }
            else
            {
                Console.WriteLine("Как-то маловато букв(");
            }
        }
        else
        {
            Console.WriteLine("Вы не ввели текст(((");
        }
    }
}