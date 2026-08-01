using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class ListNumbers
    {
        static void Main()
        {
            List<int> list = new() { 5, 2, 6, 8, 10 };

            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}