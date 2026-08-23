using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class BookingSystem
    {
        static void Main()
        {
            Dictionary<int, string> places = new Dictionary<int, string>();

            int input;
            int place;
            string name;

            while(true)
            {
                Console.WriteLine("1. Забронировать");
                Console.WriteLine("2. Посмотреть занятые");
                Console.WriteLine("3. Выход");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Введите место и имя: ");

                        place = int.Parse(Console.ReadLine());
                        name = Console.ReadLine();

                        if (!places.ContainsKey(place))
                        {
                            places.Add(place, name);
                        }
                        else
                        {
                            Console.WriteLine("Ошибка. Место уже занято.");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Список занятых мест: ");
                        foreach (var pl in places)
                        {
                            Console.WriteLine(pl.Key + " " + pl.Value);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Выход из программы.");
                        return;
                }
            }
            Console.WriteLine("Все места заняты!");
        }
    }
}