using System;
using System.Collections.Generic;

public class HashSetAnagramms
{
    static void Main()
    {
        string fInput = Console.ReadLine();
        string sInput = Console.ReadLine();

        HashSet<char> fSet = new HashSet<char>(fInput);
        HashSet<char> sSet = new HashSet<char>(sInput);

        if (fInput.Length == sInput.Length)
        {
            Console.WriteLine("Слова являются аннограммами: " + sSet.SetEquals(fSet));
        }
        else
        {
            Console.WriteLine("Слова не аннограммы");
        }
    }
}