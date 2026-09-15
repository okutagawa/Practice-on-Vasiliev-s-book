using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace BookPractice
{
    public class StackHtml // вопрос
    {
        static void Main()
        {
            string input = "<b><i><z>Текст</z></i></b>";

            Stack<string> tags = new Stack<string>();

            string currentTag = "";
            bool insideTag = false;

            foreach (char c in input)
            {
                if (c == '<')
                {
                    insideTag = true;
                    currentTag = "<";
                }
                else if (c == '>' && insideTag)
                {
                    insideTag = false;
                    currentTag += ">";

                    if (currentTag[0] == '<' && currentTag[1] == '/')
                    {
                        string name = currentTag.Substring(2, currentTag.Length - 3);

                        if (tags.Count == 0)
                        {
                            Console.WriteLine("Ошибка: закрывающий тег без открывающего.");
                            return;
                        }

                        if (tags.Peek() != name)
                        {
                            Console.WriteLine("Ошибка: неправильная вложенность тегов.");
                            return;
                        }

                        tags.Pop();
                    }
                    else
                    {
                        string name = currentTag.Substring(1, currentTag.Length - 2);
                        tags.Push(name);
                    }
                }
                else if (insideTag)
                {
                    currentTag += c;
                }
            }

            if (tags.Count == 0)
            {
                Console.WriteLine("Все теги закрыты правильно!");
            }
            else
            {
                Console.WriteLine("Ошибка: остались незакрытые теги.");
            }
            
        }
    }
}