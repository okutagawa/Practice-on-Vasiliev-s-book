using System;

namespace PalindromeMethod;

public class PalindromeMethod
{
    static void Main()
    {
        string text = "топот";

        bool result = IsPalindrome(text);

        Console.WriteLine(result);
    }

    static bool IsPalindrome(string text)
    {
        bool palindrome = false;

        if (text.Length == 0 || text.Length == 1)
        {
            return true;
        }
        else if (text[0] == text[text.Length - 1])
        {
            return false;
        }

        if (text.Length % 2 == 0)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] == text[text.Length - 1 - i])
                {
                    palindrome = true;
                }
                else
                {
                    palindrome = false;
                }
            }
            
        }

        if (text.Length % 2 == 1)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == text[text.Length - 1 - i])
                {
                    palindrome = true;
                }
                else
                {
                    palindrome = false;
                }
            }
        }

        return palindrome;

    }
}