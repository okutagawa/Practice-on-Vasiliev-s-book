using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class PayDay
    {
        static void Main()
        {
            Dictionary<string, int> balance = new()
            {
                { "Саша", 100 },
                { "Егор", 200 },
                { "Дима", 50 },
            };

            Console.Write("Введите имя отправителя: ");
            string nameFrom = Console.ReadLine();

            Console.Write("Введите имя получателя: ");
            string nameTo = Console.ReadLine();

            Console.Write("Введите сумму: ");
            int sum = int.Parse(Console.ReadLine());
            int result;

            if (balance.ContainsKey(nameFrom) && balance.ContainsKey(nameTo) && balance[nameFrom] >= sum)
            {
                balance[nameFrom] -= sum;
                balance[nameTo] += sum;
            }
            else
            {
                Console.WriteLine("Ошибка, такого клиента в базе не существует или сумма превышает баланс");
            }

            Console.WriteLine("Текущий счет клиентов: ");
            foreach(var bal in balance)
            {
                Console.WriteLine(bal.Key + " " + bal.Value);
            }
        }
    }
}