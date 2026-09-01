using System;
using System.Collections.Generic;
using System.Data;

namespace BookPractice
{
    public class NPCdatabase
    {
        static void Main()
        {
            Dictionary<int, string> npcs = new()
            {
                { 1, "Bot_Misha" },
                { 2, "Bot_Collapse" },
                { 3, "Bot_Yatoro" },
                { 4, "Bot_Nisha" },
                { 5, "Bot_Sasha" },
            };

            Dictionary<int, int> location = new()
            {
                { 1, 0345 },
                { 2, 25 },
                { 3, 777 },
                { 4, 02 },
                { 5, 01 },
            };
 
            int input;

            int id;
            Console.WriteLine("Выберите действие нажав кнопку рядом с ним.");
            while (true)
            {
                Console.WriteLine("1. Вывести всех NPC");
                Console.WriteLine("2. Найти по ID");
                Console.WriteLine("3. Завершение работы");
                Console.WriteLine();

                input = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Список всех NPC: ");
                        foreach (var n in npcs)
                        {
                            Console.WriteLine("Имя NPC: " + n.Value + "; локация: " + location[n.Key] + ".");
                        }       
                        Console.WriteLine();
                        break;
                    case 2:
                        id = int.Parse(Console.ReadLine());
                        if (npcs.ContainsKey(id))
                        {
                            Console.WriteLine("NPC " + npcs[id] + " существует в базе данных.");
                        }
                        else
                        {
                            Console.WriteLine("Ошибка, такого NPC не существует.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Завершение работы");
                        return;
                }
            }
        }
    }
}