using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class StackHistory
    {
        static void Main()
        {
            Stack<string> stack = new Stack<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "undo")
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine($"Отменено: [{stack.Pop()}]");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка. Стек пустой.");
                    }
                }
                else if (input == "exit")
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                else
                {
                    stack.Push(input);
                    Console.WriteLine($"Добавлено: [{input}]");
                }
            }
        }
    }
}