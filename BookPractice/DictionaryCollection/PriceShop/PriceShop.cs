using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class PriceShop
    {
        static void Main()
        {
            Dictionary<string, int> products = new()
            {
                {"Яблоко", 50 },
                {"Молоко", 80 },
                {"Хлеб", 30 },
            };

            Console.Write("Укажите навзание желаемого продукта: ");
            string product = Console.ReadLine();
            Console.Write("Укажите количество желаемого продукта: ");
            int quant = int.Parse(Console.ReadLine());

            if (products.ContainsKey(product))
            {
                Console.WriteLine($"Общая стоимость товара {product} {quant} шт. = {products[product] * quant} рублей.");
            }
            else
            {
                Console.WriteLine("Такого продукта нет.");
            }
        }
    }
}