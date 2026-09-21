using System;

namespace ClassBaseExample
{
    // Класс — это описание типа объекта.
    // Здесь мы описываем, какими данными и действиями обладает Player.
    class Player
    {
        // Поля — состояние объекта.
        public string Name;
        public int Health;
        public int Money;

        // Метод без возвращаемого значения.
        // Он изменяет состояние текущего объекта.
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        // Метод с параметром.
        public void EarnMoney(int amount)
        {
            Money += amount;
        }

        // Метод с возвращаемым значением bool.
        public bool IsAlive()
        {
            return Health > 0;
        }

        // Метод, который получает другой объект Player.
        public void Attack(Player enemy, int damage)
        {
            // enemy — ссылка на объект, который передали в метод.
            enemy.TakeDamage(damage);
        }
    }

    class Program
    {
        static void Main()
        {
            // ---------------------------------------------------
            // 1. СОЗДАНИЕ ОБЪЕКТА
            // ---------------------------------------------------

            // Player — тип.
            // player1 — переменная, которая хранит ссылку на объект.
            // new Player() — создание нового объекта.
            Player player1 = new Player();


            // ---------------------------------------------------
            // 2. РАБОТА С ПОЛЯМИ
            // ---------------------------------------------------

            player1.Name = "Alex";
            player1.Health = 100;
            player1.Money = 5000;

            Console.WriteLine(player1.Name);
            Console.WriteLine(player1.Health);
            Console.WriteLine(player1.Money);


            // ---------------------------------------------------
            // 3. ВЫЗОВ МЕТОДОВ ОБЪЕКТА
            // ---------------------------------------------------

            player1.TakeDamage(20);

            // Health: 100 -> 80
            Console.WriteLine($"После урона: {player1.Health}");

            player1.EarnMoney(1500);

            // Money: 5000 -> 6500
            Console.WriteLine($"Деньги: {player1.Money}");


            // ---------------------------------------------------
            // 4. МЕТОД С ВОЗВРАЩАЕМЫМ ЗНАЧЕНИЕМ
            // ---------------------------------------------------

            bool alive = player1.IsAlive();

            Console.WriteLine($"Жив: {alive}");


            // ---------------------------------------------------
            // 5. ДВА НЕЗАВИСИМЫХ ОБЪЕКТА
            // ---------------------------------------------------

            Player player2 = new Player();

            player2.Name = "Bandit";
            player2.Health = 60;
            player2.Money = 1000;

            // player1 и player2 — два разных объекта.
            player1.TakeDamage(10);

            // Изменился только player1.
            Console.WriteLine($"player1 HP: {player1.Health}");
            Console.WriteLine($"player2 HP: {player2.Health}");


            // ---------------------------------------------------
            // 6. ДВЕ ССЫЛКИ НА ОДИН ОБЪЕКТ
            // ---------------------------------------------------

            Player player3 = player1;

            // Новый объект здесь НЕ создаётся.
            // player1 и player3 теперь ссылаются на один объект.

            player3.Health = 30;

            // Поэтому изменение через player3 видно и через player1.
            Console.WriteLine($"player1 HP: {player1.Health}");
            Console.WriteLine($"player3 HP: {player3.Health}");


            // ---------------------------------------------------
            // 7. ПЕРЕНАЗНАЧЕНИЕ ССЫЛКИ
            // ---------------------------------------------------

            player3 = new Player();

            // Теперь создан новый объект.
            // player3 больше не ссылается на тот же объект, что player1.

            player3.Name = "John";
            player3.Health = 100;

            Console.WriteLine($"player1: {player1.Name}, HP: {player1.Health}");
            Console.WriteLine($"player3: {player3.Name}, HP: {player3.Health}");


            // ---------------------------------------------------
            // 8. ВЗАИМОДЕЙСТВИЕ ДВУХ ОБЪЕКТОВ
            // ---------------------------------------------------

            Player fighter1 = new Player();
            fighter1.Name = "Player";
            fighter1.Health = 100;

            Player fighter2 = new Player();
            fighter2.Name = "Enemy";
            fighter2.Health = 70;

            // fighter2 передаётся в метод как объект.
            fighter1.Attack(fighter2, 25);

            // fighter2.Health: 70 -> 45
            Console.WriteLine($"{fighter2.Name} HP: {fighter2.Health}");


            // ---------------------------------------------------
            // 9. ПЕРЕДАЧА ОБЪЕКТА В ОБЫЧНЫЙ МЕТОД
            // ---------------------------------------------------

            ShowStats(fighter1);
            ShowStats(fighter2);


            // ---------------------------------------------------
            // ИТОГ
            // ---------------------------------------------------

            /*
                Класс:
                class Player

                Создание объекта:
                Player player = new Player();

                Поле:
                player.Health = 100;

                Метод:
                player.TakeDamage(20);

                Метод с результатом:
                bool alive = player.IsAlive();

                Новый объект:
                Player a = new Player();
                Player b = new Player();

                Один объект, две ссылки:
                Player b = a;

                Передача объекта:
                Attack(Player enemy)

                Главное:
                new создаёт новый объект.
                Присваивание одной переменной класса другой
                копирует ссылку, а не сам объект.
            */
        }

        // Метод принимает объект Player.
        static void ShowStats(Player player)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine($"Имя: {player.Name}");
            Console.WriteLine($"HP: {player.Health}");
            Console.WriteLine($"Деньги: {player.Money}");
            Console.WriteLine($"Жив: {player.IsAlive()}");
        }
    }
}