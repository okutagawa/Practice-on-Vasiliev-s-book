using System;
using System.Collections.Generic;

public class HashSetFriends
{
    static void Main()
    {
        Dictionary<string, HashSet<string>> friends = new Dictionary<string, HashSet<string>>()
        {
            { "Егор", new HashSet<string> { "Саша", "Дима", "Андрей" } },
            { "Саша", new HashSet<string> { "Егор", "Никита", "Максим", "Дима" } },
            { "Максим", new HashSet<string> { "Никита", "Леха", "Ибра"} }
        };

        bool result1 = MutalFriends("Егор", "Саша", friends);

        Console.WriteLine("Егор и Саша взаимные друзья? " + result1);

        bool result2 = MutalFriends("Егор", "Максим", friends);

        Console.WriteLine("Егор и Максим взаимные друзья? " + result2);

        PrintMutalFriends("Саша", "Максим", friends);
    }

    static bool MutalFriends(string player1, string player2, Dictionary<string, HashSet<string>> friends)
    {
        return friends[player1].Contains(player2) && friends[player2].Contains(player1);
        
    }

    static void PrintMutalFriends(string player1, string player2, Dictionary<string, HashSet<string>> friends)
    {
        HashSet<string> mutal = new HashSet<string>(friends[player1]);

        mutal.IntersectWith(friends[player2]);

        Console.WriteLine($"Общие друзья {player1} и {player2}: " + string.Join(", ", mutal));
    }
}