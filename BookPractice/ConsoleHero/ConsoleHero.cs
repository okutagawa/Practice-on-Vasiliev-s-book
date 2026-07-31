using System;

namespace BookPractice;

public class ConsoleHero
{
    static void Main()
    {

        InitializeHero(out int heroHP, out int heroDamage, out int heroArmor, out int[] inventory);
        
        string[] enemyNames = { "Гоблин", "Орк", "Скелет", "Дракончик" };

        string randEnemy;

        while(true)
        {
            ShowMenu();
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:                  
                    CreateEnemy(enemyNames, out int enemyHp, out int enemyDamage, out randEnemy);
                    Battle(ref heroHP, ref heroDamage, ref heroArmor, ref inventory, randEnemy, ref enemyHp, ref enemyDamage);
                    break;
                case 2:
                    ShowInventory(inventory);
                    break;
                case 3:
                    Console.WriteLine("Выход из игры");
                    return;
            }
        }

        // Console.WriteLine(RollDice(3, 10));
    }

    // Меню игры
    static void ShowMenu()
    {
        Console.WriteLine("Выберите действие: ");
        Console.WriteLine("1. Вступить в бой (вызвать врага)");
        Console.WriteLine("2. Посмотреть инвентарь");
        Console.WriteLine("3. Выйти из игры");
    }

    // Статы персонажа
    static void InitializeHero(out int heroHP, out int heroDamage, out int heroArmor, out int[] inventory)
    {
        heroHP = 100;
        heroDamage = 15;
        heroArmor = 5;

        inventory = new int[5];
    }

    // Генерация урона и врагов
    static int RollDice(int min, int max)
    {
        Random rnd = new Random();

        return rnd.Next(min, max);
    }

    // Создаем противника
    static void CreateEnemy(string[] enemyNames, out int enemyHp, out int enemyDamage, out string randEnemy)
    {
        Random rand = new Random();
        randEnemy = enemyNames[rand.Next(enemyNames.Length)]; // выбираем рандомное название противника из массива

        // Задаем хп и дамаг через метод генерации
        enemyHp = RollDice(10, 30); 
        enemyDamage = RollDice(3, 8);
    }

    // Процесс боя
    static void Battle(ref int heroHp, ref int heroDamage, ref int heroArmor, ref int[] inventory, string randEnemy, ref int enemyHp, ref int enemyDamage)
    {
        while (heroHp > 0 && enemyHp > 0)
        {
            ShowBattleStats(heroHp, enemyHp); // вывод текущего состояния героя и противника
            BattleMenu(); // меню выбора

            int choise = int.Parse(Console.ReadLine());

            switch(choise)
            {
                case 1:
                    Attack(ref enemyHp, heroDamage);
                    break;
                case 2:
                    heroHp =- Defend(enemyDamage, heroArmor);
                    break;
                case 3:
                    UsePotion(ref heroHp);
                    break;
            }
        }
    }

    // Вывод статистики 
    static void ShowBattleStats(int heroHP, int enemyHp)
    {
        Console.WriteLine("Информация о текущем состоянии боя: ");
        Console.WriteLine($"HP вашего персонажа = {heroHP}");
        Console.WriteLine($"HP противника = {enemyHp}");
    }

    // Меню боя и выбора действия
    static void BattleMenu()
    {
        Console.WriteLine("Выберите действие: ");
        Console.WriteLine("1. Атаковать");
        Console.WriteLine("2. Защититься");
        Console.WriteLine("3. Использовать зелье из инвентаря");
    }

    // Логика атаки и вычисления ХП
    static void Attack(ref int enemyHp, int heroDamage)
    {
        Random rnd = new Random();

        enemyHp =- rnd.Next(heroDamage - 2, heroDamage +2);
    }

    // Логика блокирования урона и защиты
    static int Defend(int enemyDamage, int heroArmor)
    {
        if (enemyDamage > heroArmor)
        {
            return enemyDamage - heroArmor;
        }
        else
        {
            return 0;
        }
    }

    static void UsePotion(ref int heroHp)
    {

    }

    static void UsePotion(int[] inventory, int index)
    {

    }

    static void ShowInventory(int[] inventory)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            Console.Write(inventory[i] + " ");
        }
    }
}