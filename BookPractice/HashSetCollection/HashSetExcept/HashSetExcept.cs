using System;
using System.Collections.Generic;

public class HashSetExcept
{
    static void Main()
    {
        HashSet<string> allEnemy = new HashSet<string>
        {
            "Орк",
            "Циклоп",
            "Дракон",
            "Тролль",
            "Гоблин",
            "Зомби",
            "Вампир",
            "Гуль"
        };

        Console.WriteLine("Список всех врагов: " + string.Join(", ", allEnemy));

        HashSet<string> dieEnemy = new HashSet<string>
        {
            "Зомби",
            "Гуль",
            "Дракон"
        };

        Console.WriteLine("Список убитых врагов: " + string.Join(", ", dieEnemy));

        HashSet<string> liveEnemy = new HashSet<string>(allEnemy);
        liveEnemy.ExceptWith(dieEnemy);

        Console.WriteLine("Список живых врагов: " + string.Join(", ", liveEnemy));
    }
}