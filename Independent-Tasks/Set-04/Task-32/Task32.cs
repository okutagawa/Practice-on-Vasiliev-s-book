using System;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Security.Principal;

namespace BookPractice;

// Задание из Stepik Крестики-нолики.

// Напиши программу, которая покажет, сколько товаров каждой категории осталось на складе после выполнения всех заказов.


//Помоги Михаилу дописать недостающий фрагмент, чтобы он успел сдать работу в срок и спокойно отдохнуть летом.


//Формат входных данных:
//Три строки, каждая из которых содержит три символа через пробел — текущее состояние игрового поля.Каждый символ — это либо X, либо O.
//Гарантируется, что все клетки заполнены, и что в игре только один победитель (или ничья).

//Формат выходных данных:
//Одна строка в зависимости от результата игровой партии:

//Победили крестики, если победу одержали крестики (X);
//Победили нолики, если победили нолики(O);
//Ничья, если никто не выиграл.


class Task32
{
    public static void Main()
    {
        int n = 3;

        char[,] game = new char[n,n];

        for (int i = 0; i < n; i++)
        {
            string[] z = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                game[i, j] = char.Parse(z[j]);
            }
        }

        int countZero = 0; // счетчик для проверки победы ноликов
        int countPoint = 0; // счетчик для проверки победы крестиков
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n;j++)
            {
                if (game[i, j] == 'O') // если мы нашли нолик, то далее начинаем проверку
                {
                    // устанавливаем границы и проверяем вертикаль для нулей
                    if (i + 2 < n)
                    {
                        if (game[i, j] == game[i + 1, j] && game[i + 1, j] == game[i + 2, j])
                        {
                            countZero++;
                            break;
                        }
                    }
                    // устанавливаем границы и проверяем горизонталь для нулей
                    if (j + 2 < n)
                    {

                        if (game[i, j] == game[i, j + 1] && game[i, j + 1] == game[i, j + 2])
                        {
                            countZero++;
                            break;
                        }
                    }
                    if (i + 2 < n && j + 2 < n)  // Проверяем границы к главной диагонали
                    {
                        if (game[i, j] == game[i + 1, j + 1] &&
                            game[i, j] == game[i + 2, j + 2])
                        {
                            countZero++;
                            break;
                        }
                    }
                    if (i + 2 < n && j - 2 >= 0) // Проверяем границы к побочной диагонали
                    {
                        if (game[i, j] == game[i + 1, j - 1] &&
                            game[i, j] == game[i + 2, j - 2])
                        {
                            countZero++;
                            break;
                        }
                    }
                }
                if (game[i, j] == 'X')
                {
                    if (i + 2 < n)
                    {
                        if (game[i, j] == game[i + 1, j] && game[i + 1, j] == game[i + 2, j])
                        {
                            countPoint++;
                            break;
                        }
                    }
                    if (j + 2 < n)
                    {

                        if (game[i, j] == game[i, j + 1] && game[i, j + 1] == game[i, j + 2])
                        {
                            countPoint++;
                            break;
                        }
                    }
                    if (i + 2 < n && j + 2 < n)  // Проверяем границы к главной диагонали
                    {
                        if (game[i, j] == game[i + 1, j + 1] &&
                            game[i, j] == game[i + 2, j + 2])
                        {
                            countPoint++;
                            break;
                        }
                    }
                    if (i + 2 < n && j - 2 >= 0) // Проверяем границы к побочной диагонали
                    {
                        if (game[i, j] == game[i + 1, j - 1] &&
                            game[i, j] == game[i + 2, j - 2])
                        {
                            countPoint++;
                            break;
                        }
                    }
                }

            }
        }

        if (countZero != 0 && countPoint == 0)
        {
            Console.WriteLine("Победили нолики");
        }
        else if (countPoint != 0 && countZero == 0)
        {
            Console.WriteLine("Победили крестики");
        }
        else
        {
            Console.WriteLine("Ничья");
        }
    }
}