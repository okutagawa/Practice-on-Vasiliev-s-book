using System;
using System.Collections.Generic;

namespace BookPractice
{
    class ListExample
    {
        static void Main()
        {
            // стандартное объявление и заполнение списка
            List<string> socialNetworks = new List<string>();

            socialNetworks.Add("Youtube");
            socialNetworks.Add("Telegram");
            socialNetworks.Add("Instagram");

            // List<string> socialNetworks = new() { "Youtube", "Telegram", "Instagram" }; // альтернатива объявления списка

            socialNetworks.Insert(1, "Tiktok"); // вставка в список по индексу

            // socialNetworks.Remove("Telegram"); // удаление по элементу

            // socialNetworks.RemoveAt(2); // удаление по индексу

            // перенос содержимого из массива в список
            string[] socialNetworksArray = { "VK", "Max", "Odnoklassniki" };

            socialNetworks.AddRange(socialNetworksArray);



            socialNetworks.Sort(); //  сортировка по алфавиту

            Console.WriteLine(socialNetworks.Count() + "\n"); // отображение кол-ва элементов в списке

            foreach (string socialNetwork in socialNetworks)
            {
                Console.WriteLine(socialNetwork);
            }

            Console.ReadLine();
        }
    }
}
