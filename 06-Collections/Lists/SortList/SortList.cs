using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class SortList
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            CreateList(numbers);

            foreach (int nums in numbers)
            {
                Console.Write(nums + " ");
            }
            Console.WriteLine();
            BubbleSort(numbers);

            foreach (int nums in numbers)
            {
                Console.Write(nums + " ");
            }
        }

        static void CreateList(List<int> numbers)
        {
            Random rnd = new Random();

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(rnd.Next(1, 50));
                sum += numbers[i];
            }
        }

        static void BubbleSort(List<int> numbers)
        {
            int temp = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = 0; j < numbers.Count - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
        }
    }
}