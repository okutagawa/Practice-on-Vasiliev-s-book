using System;

namespace ClassBaseFighter
{
    class Program
    {
        static void Main()
        {
            Fighter player = new Fighter();
            Fighter enemy = new Fighter();

            player.Name = "Player";
            player.Health = 100;
            player.Damage = 25;

            enemy.Name = "Bandito";
            enemy.Health = 80;
            enemy.Damage = 15;

            player.Attack(enemy);
            enemy.Attack(player);

            player.Attack(enemy);
            enemy.Attack(player);
            enemy.Attack(player);

            Stats(player);
            Stats(enemy);

        }

        static void Stats(Fighter person)
        {
            bool alive = person.IsAlive();

            Console.WriteLine($"Персонажа зовут - {person.Name}");
            Console.WriteLine($"У персонажа: {person.Health} HP");
            Console.WriteLine($"Статус жизни персонажа: {alive}");
            Console.WriteLine();
        }
    }
}