using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class DictionaryInvert
    {
        static void Main()
        {
            Dictionary<string, int> nameAge = new()
            {
                { "Михаил", 21 },
                { "Степан", 30 },
                { "Александр", 22 },
                { "Максим", 16 },
                { "Дима", 16 },
                { "Макс", 16 },
                { "Гена", 16 },
                { "Алеша", 16 },

            };


            foreach (var na in nameAge)
            {
                Console.WriteLine(na.Key + " " + na.Value);
            }


            Dictionary<int, List<string>> ageNames = new Dictionary<int, List<string>>();

            foreach (var nam in nameAge)
            {
                int age = nam.Value;
                string name = nam.Key;

                if (ageNames.ContainsKey(age))
                {
                    ageNames[age].Add(name);
                }
                else
                {
                    List<string> newList = new List<string>();
                    newList.Add(name);
                    ageNames.Add(age, newList);
                }
            }

            foreach (var ag in ageNames)
            {
                Console.Write($"Возраст: {ag.Key} - ");

                foreach (string name in ag.Value) 
                {
                    Console.Write(name + " ");
                }
                Console.WriteLine();
            }

        }
    }
}