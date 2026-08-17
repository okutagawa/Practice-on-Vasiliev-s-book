using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class ListShopping
    {
        static void Main()
        {
            List<string> products = new() {"Помидор", "Картошка", "Чипсы", "Мясо", "Молоко"};

            string input = Console.ReadLine();

            
            if (products.Contains(input))
            {
                Console.WriteLine($"Был удален продукт: {input}");
                products.Remove(input);
            }
            else
            {
                Console.WriteLine($"Был добавлен продукт: {input}");
                products.Add(input);
            }
            
            
            Console.WriteLine();

            foreach (string product in products)
            {
                Console.Write(product + " ");
            }
            
        }
    }
}