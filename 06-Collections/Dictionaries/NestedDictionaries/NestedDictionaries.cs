using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class NestedDictionaries
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> shops = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> productsFirst = new()
            {
                { "Молоко", 80 },
                { "Хлеб", 90 },
                { "Яйца", 110 },
            };

            Dictionary<string, int> productsSecond = new()
            {
                { "Лимонад", 50 },
                { "Пицца", 150 },
                { "Чипсы", 70 },
            };

            shops.Add("Пятерочка", productsFirst);
            shops.Add("Магнит", productsSecond);

            foreach (var shop in shops)
            {
                Console.Write("Магазин " + shop.Key + ": ");
                foreach (var product in shop.Value)
                {
                    Console.Write(product.Key + "(" + product.Value + ") ");
                }
                Console.WriteLine();
            }
        }
    }
}