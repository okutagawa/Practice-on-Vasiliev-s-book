using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class QueueReverse
    {
        static void Main()
        {
            Queue<int> numbers = new Queue<int>();

            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);

            List<int> tempList = numbers.ToList();

            numbers.Clear();

            for (int i = tempList.Count - 1; i >= 0; i--)
            {
                numbers.Enqueue(tempList[i]);
            }

            while (numbers.Count > 0)
            {
                Console.WriteLine("Следующее число: " + numbers.Dequeue());
            }
        }
    }
}