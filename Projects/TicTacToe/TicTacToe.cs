using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace BookPractice;

public class TicTacToe
{
    static void Main(string[] args)
    {
        string[,] map = new string[3,3] // инициализация игрового поля
        {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" },
        };

        for (int i = 0; i < 9; i++)
        {
            bool isZeroNow = (i % 2 == 1); // т.к. первыми ходят крестики мы инциализируем переменную с типом bool. В случае если выражени четное например 0, то выражение false 
            string currentPlayer = isZeroNow ? "нолики" : "крестики"; // false - крестики, true - нолики 

            Console.WriteLine($"Ходят {currentPlayer}");
            PrintMap(map); // переходим к функции PrintMap, которая выводит игровое поле

            Console.Write("Введите цифру вашего хода: ");
            Console.WriteLine();

            string cellNumber = GetPlayerCellNumber(map); // переходим к функции GetPlayerCellNumber, которая позволяет вводить число
            MakeMove(map, cellNumber, isZeroNow); // переходим к функции MakeMove, которая позволяет совершать ход 
            Console.WriteLine();

            if (HasWinner(map)) // в случае если функция HasWinner(функция позволяющая определять победителя по комбинации) truе, то переходим к его выводу
            {
                PrintMap(map); // выводим карту где видна победная комбинация
                Console.WriteLine();
                if (!isZeroNow) // здесь если ход был последний за крестиками, то выходит что они победили
                {
                    Console.WriteLine("Крестики победили!");
                }
                else if (isZeroNow)
                {
                    Console.WriteLine("Нолики победили!");
                }
                return;
            }
        }
        
        PrintMap(map); // в случае ничьей, выводим карту и выводим результат ничья
        Console.WriteLine();
        Console.WriteLine("Ничья!");
    }
    static string GetPlayerCellNumber(string[,] map) // функция отвечающая за ввод пользователем числа, а также проверку на неверный ввод
    {
        while (true)
        {
            string input = Console.ReadLine();

            if (input.Length != 1 && !char.IsDigit(input[0])) // ввод должен быть одним символом и числом
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 9.");
                continue;
            }

            char a = input[0];
            if (a < '1' || a > '9')
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру от 1 до 9.");
                continue;
            }

            if (!IsMoveCorrect(map, input)) // функция IsMoveCorrect отвечает за проверку на занятую или свободную ячейку, если функция false, то ячейка занята
            {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите цифру пустой ячейки.");
                continue;
            }
            else
            {
                return input;
            }
        }
    }

    static string[,] MakeMove(string[,] map, string cellNumber, bool isZeroNow) // функция отвечает за ход пользователя
    {
        
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == cellNumber)
                {
                    if (isZeroNow)
                    {
                        map[i,j] = "O";
                    }
                    else
                    {
                        map[i, j] = "X";
                    }
                }
            }
        }
        return map;
    }


    static bool IsMoveCorrect(string[,] map, string cellNumber) // функция отвечает за проверку на не занятую ячейку
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {           
            for (int j = 0; j < map.GetLength(1);j++)
            {
                if (map[i, j] == cellNumber)
                {
                    if (map[i,j] == "X" || map[i,j] == "O")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }           
        }
        return false;
    }

    static void PrintMap(string[,] map) // функция отвечает за вывод актуального поля игры, а так же за вывод крестиков красным цветом, а ноликов синим
    {
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == "X")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (map[i, j] == "O")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.Write(map[i, j] + " ");
                Console.ResetColor();
            }
            Console.WriteLine();
        }
    }

    static bool HasWinner(string[,] map) // функция проверяющая победные комбинации 
    {
        int countZero = 0;
        int countPoint = 0;
        for (int i = 0; i < map.GetLength(0); i++)
        {
            for (int j = 0; j < map.GetLength(1); j++)
            {
                if (map[i, j] == "X") // проверка если найден крестик
                {
                    if (i + 2 < map.GetLength(0))
                    {
                        if (map[i, j] == map[i + 1, j] && map[i + 1, j] == map[i + 2, j])
                        {
                            countPoint++;
                            break;
                        }
                    }
                    if (j + 2 < map.GetLength(1))
                    {
                        if (map[i, j] == map[i, j + 1] && map[i, j + 1] == map[i, j + 2])
                        {
                            countPoint++;
                            break;
                        }
                    }
                    if (i + 2 < map.GetLength(0) && j + 2 < map.GetLength(1)) // проверка по главной диагонали 
                    {
                        if (map[i, j] == map[i + 1, j + 1] && map[i + 1, j + 1] == map[i + 2, j + 2])
                        {
                            countPoint++;
                            break;
                        }
                    }
                    if (i + 2 < map.GetLength(0) && j - 2 >= 0) // проверка по побочной диагонали 
                    {
                        if (map[i, j] == map[i + 1, j - 1] && map[i + 1, j - 1] == map[i + 2, j - 2])
                        {
                            countPoint++;
                            break;
                        }
                    }
                }
                if (map[i, j] == "O") // проверка если найден нолик
                {
                    if (i + 2 < map.GetLength(0))
                    {
                        if (map[i, j] == map[i + 1, j] && map[i + 1, j] == map[i + 2, j])
                        {
                            countZero++;
                            break;
                        }
                    }
                    if (j + 2 < map.GetLength(1))
                    {
                        if (map[i, j] == map[i, j + 1] && map[i, j + 1] == map[i, j + 2])
                        {
                            countZero++;
                            break;
                        }
                    }
                    if (i + 2 < map.GetLength(0) && j + 2 < map.GetLength(1))
                    {
                        if (map[i, j] == map[i + 1, j + 1] && map[i + 1, j + 1] == map[i + 2, j + 2])
                        {
                            countZero++;
                            break;
                        }
                    }
                    if (i + 2 < map.GetLength(0) && j - 2 >= 0)
                    {
                        if (map[i, j] == map[i + 1, j - 1] && map[i + 1, j - 1] == map[i + 2, j - 2])
                        {
                            countZero++;
                            break;
                        }
                    }
                }
            }
        }
        if (countPoint != 0 || countZero != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}