using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class NearestNumber
    {
        static void Main()
        {           
            List<int> numbers = new List<int>();

            CreateList(numbers);

            int input = int.Parse(Console.ReadLine());

            int closest = numbers[0];
            int minDifference = Math.Abs(numbers[0] - input);


            foreach (int number in numbers)
            {
                int currentDifference = Math.Abs(number - input);

                if (currentDifference < minDifference)
                {
                    minDifference = currentDifference;
                    closest = number;
                }
            }

            Console.WriteLine($"Ближайшее число: {closest}");

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
    }
}