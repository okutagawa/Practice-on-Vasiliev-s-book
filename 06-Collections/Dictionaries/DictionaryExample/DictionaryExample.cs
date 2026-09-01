using System;
using System.Collections.Generic;

namespace BookPractice
{
    public class DictionaryExample
    {
        static void Main()
        {
            // Словарь это структура данных, которая хранит в себе объекты по ключу и значению
            // То есть у нас есть ключ в нашем словаре и по этому ключу содержится какое-то значение
            
            // Dictionary<int, string> dict = new Dictionary<int, string>(); - стандартное объявление пустого словаря

            // Ещё один способ как можно задать словарь
            //Dictionary<int, string> dict = new Dictionary<int, string>
            //{
            //    [1] = "Строка один",
            //    [2] = "Строка два",
            //    [3] = "Строка три",
            //    [4] = "Строка четыре",
            //    [5] = "Строка пять",
                
            //};

            //Dictionary<int, string> states = new()
            //{
            //    {1, "США"},
            //    {2, "Япония" },
            //    {3, "Китай" },
            //};

            //// добавление
            //states.Add(4, "Австрия");

            //PrintDictionary(states);

            // удаление по ключу
            //states.Remove(3); // вопрос

            //PrintDictionary(states);

            // очистка словаря
            //states.Clear();

            //PrintDictionary(states);

            // вывод элемента по ключу
            //Console.WriteLine($"Лучшая страна - {states[2]}");

            HomeWork();
        }
        
        static void PrintDictionary(Dictionary<int,string> dict)
        {
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
        }
        // домашнее задание
        static void HomeWork()
        {
            Dictionary<int, string> programmLang = new()
            {
                {1, "C#" },
                {2, "Rust" },
                {3, "C" },
                {4, "Go" },
                {5, "JavaScript" },
                {6, "C++" },
                {7, "Python" },
                {8, "TypeScript" },
                {9, "Lua" },
                {10, "PHP" },
                {11, "Java" },
                {12, "Kotlin" },
            };

            var filtered = programmLang.Where(x => x.Key % 2 != 0).ToDictionary(x => x.Key, x => x.Value);

            programmLang = filtered;

            PrintDictionary(programmLang);

            programmLang.Clear();

            programmLang.Add(1, "C#");

            Console.WriteLine($"Я программирую на {programmLang[1]}");
        }
    }
}