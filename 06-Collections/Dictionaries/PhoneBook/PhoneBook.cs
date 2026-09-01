using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class PhoneBook
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new()
            {
                { "Степа", "89024124251" },
                { "Максим", "89023124325" },
                { "Саша", "89022187382" },
            };

            string input = Console.ReadLine();

            if (phoneBook.ContainsKey(input))
            {
                Console.WriteLine($"Номер контакта {input}: {phoneBook[input]}");
            }
            else
            {
                Console.WriteLine("Контакт не найден.");
            }
        }
    }
}