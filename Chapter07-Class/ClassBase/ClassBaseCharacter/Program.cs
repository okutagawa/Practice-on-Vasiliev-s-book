using System;

namespace ClassBaseCharacter
{
    class Program
    {
        static void Main()
        {
            GameCharacter person = new GameCharacter();

            person.Name = "Alex";
            person.Health = 120;
            person.Money = 12000;
            person.Level = 750;

            person.TakeDamage(20);
            person.TakeCash(5000);
            person.GiveCash(1200);
            person.LevelUp(90);


            Stats(person);
        }

        static void Stats(GameCharacter person)
        {
            Console.WriteLine($"Вашего персонажа зовут - {person.Name}");
            Console.WriteLine($"У Вашего персонажа: {person.Health} HP");
            Console.WriteLine($"У Вашего персонажа: {person.Money}$");
            Console.WriteLine($"У Вашего персонажа: {person.Level} LVL");
        }
    }
}