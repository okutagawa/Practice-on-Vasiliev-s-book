using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace BookPractice
{
    public class MiniNotebook
    {
        static void Main()
        {
            Console.WriteLine("Добро пожаловать в блокнот");
            UserPanel(); // панель для пользователя

            List<string> notebook = new List<string>();        

            NotebookOp(ref notebook); // метод операций со списком   
        }

        static void NotebookOp(ref List<string> notebook)
        {
            while (true) // бесконечный массив пока не будет return
            {            
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (input)
                {
                    case 1:
                        Console.Write("Введите слово: ");
                        notebook.Add(Console.ReadLine());
                        UserPanel();
                        break;
                    case 2:
                        Console.Write("Введите номер записи: ");
                        notebook.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                        UserPanel();
                        break;
                    case 3:
                        Console.WriteLine("Ваш блокнот содержит следующие записи: ");
                        foreach (string note in notebook)
                        {
                            Console.WriteLine(note);
                        }
                        UserPanel();
                        break;
                    case 4:
                        Console.WriteLine("Выход из программы");
                        return;
                }
            }
        }

        static void UserPanel()
        {
            Console.WriteLine();
            Console.WriteLine("Пожалуйста, укажите действие, которое вы хотите выполнить: ");
            Console.WriteLine("1. Добавить запись");
            Console.WriteLine("2. Удалить запись по номеру");
            Console.WriteLine("3. Вывести все записи");
            Console.WriteLine("4. Выйти");
            Console.WriteLine();
        }
    }
}