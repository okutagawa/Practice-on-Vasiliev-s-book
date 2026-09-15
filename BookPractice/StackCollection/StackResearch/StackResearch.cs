using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class StackResearch
    {
        static void Main()
        {
            string input = "((3 + 2) * (5 - 1))";

            Stack<char> text = new Stack<char>();

            foreach (char a in input)
            {
                if (a == '(')
                {
                    text.Push('(');
                }
                else if (a == ')')
                {
                    if (text.Count > 0)
                    {
                        text.Pop();
                    }
                    else
                    {
                        Console.WriteLine("Ошибка, закрывающих больше.");
                        return;
                    }
                }
            }

            if (text.Count == 0)
            {
                Console.WriteLine("Все верно, стек пустой.");
            }
            else if (text.Count > 0) 
            {
                Console.WriteLine("Ошибка, открывающих скобок больше.");
            }
        }
    }
}