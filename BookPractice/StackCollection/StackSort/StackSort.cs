using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BookPractice
{
    public class StackSort
    {
        static void Main()
        {
            Random rnd = new Random();

            Stack<int> numbers = new Stack<int>();

            for (int i = 0; i < 16; i++)
            {
                numbers.Push(rnd.Next(1, 50));
            }

            Stack<int> sortNums = new Stack<int>();

            while (numbers.Count > 0) // вопрос по алгоритму
            {
                int temp = numbers.Pop();

                while (sortNums.Count > 0 && sortNums.Peek() > temp)
                {
                    numbers.Push(sortNums.Pop());
                }

                sortNums.Push(temp);
            }

            while (sortNums.Count > 0)
            {
                numbers.Push(sortNums.Pop());
            }

            foreach(int a in numbers)
            {
                Console.WriteLine(a);
            }
        }
    }
}