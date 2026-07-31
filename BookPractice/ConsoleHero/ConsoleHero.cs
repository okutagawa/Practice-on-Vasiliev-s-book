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
        bool victory = false;
        
        while (heroHp > 0 && enemyHp > 0)
        {
            ShowBattleStats(heroHp, enemyHp); // вывод текущего состояния героя и противника
            BattleMenu(); // меню выбора

            int choise = int.Parse(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    HeroAttack(ref enemyHp, heroDamage);
                    EnemyAttack(ref heroHp, enemyDamage);
                    break;
                case 2:
                    heroHp =- Defend(enemyDamage, heroArmor);
                    break;
                case 3:
                    UsePotion(ref heroHp, ref inventory);
                    EnemyAttack(ref heroHp, enemyDamage);
                    break;
            }

            victory = Victory(enemyHp, ref inventory);
        }

        if (victory)
        {
            Console.WriteLine("Вы победили противника! Вы получаете 1 зелье!");
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

    // Атака героя
    static void HeroAttack(ref int enemyHp, int heroDamage)
    {
        Random rnd = new Random();

        enemyHp -= rnd.Next(heroDamage - 2, heroDamage +2);

    }

    // Атака противника
    static void EnemyAttack(ref int heroHp, int enemyDamage)
    {
        Random rnd = new Random();

        heroHp -= rnd.Next(enemyDamage - 2, enemyDamage + 2);
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

    // Логика использования зелья
    static void UsePotion(ref int heroHp, ref int[] inventory)
    {
        int sum = 0;

        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == 1)
            {            
                if (heroHp + 30 > 100)
                {
                    heroHp = 100;
                }
                else
                {
                    heroHp += 30;
                }
                UsePotion(ref inventory, i);
                break;
            }
            else 
            {
                sum++;
            }

            if (sum == 5)
            {
                Console.WriteLine("Ваш инвентарь пуст!");
            }
        }
    }

    static void UsePotion(ref int[] inventory, int index)
    {
        inventory[index] = 0; 
    }

    // Просмотр содержимого инвентаря
    static void ShowInventory(int[] inventory)
    {
        int count = 0;
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == 1)
            {
                count++;
            } 
        }
        Console.WriteLine($"\nВаш инвентарь содержит {count} зелий.");
        Console.WriteLine("\n");
    }

    // Проверка победы
    static bool Victory(int enemyHp, ref int[] inventory)
    {
        if (enemyHp > 0)
        {
            return false;
        }
        else
        {
            AddPotion(ref inventory);
            return true;
        }
    }

    // Добавление зелья за победу
    static void AddPotion(ref int[] inventory)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == 0)
            {
                inventory[i] = 1;
                break;
            }
        } 
    }
}