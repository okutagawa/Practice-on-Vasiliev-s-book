using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class ListIntersection
    {
        static void Main()
        {
            List<int> firstList = new() { 1, 2, 3, 4 };

            List<int> secondList = new() { 3, 4, 5, 6 };

            List<int> resultList = new List<int>();

            for (int i = 0; i < firstList.Count; i++)
            {
                for (int j = 0; j < secondList.Count; j++)
                {
                    if (firstList[i] == secondList[j])
                    {
                        resultList.Add(secondList[j]);
                    }
                }
            }

            foreach (int res in resultList)
            {
                Console.Write(res + " ");
            }
        }
    }
}