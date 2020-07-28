using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Balanced_Parenthesis
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Dictionary<char, char> dict = new Dictionary<char, char>()
            {
                {')', '(' },
                {']', '[' },
                {'}', '{' },
            };
            Stack<char> chars = new Stack<char>();
            char[] closing = new char[] { '}', ']', ')' };

            char[] opening = new char[] { '{', '[', '(' };

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (opening.Contains(input[i]))
                {
                    chars.Push(input[i]);
                }
                else if (closing.Contains(input[i]))
                {
                    char curr = chars.Peek();
                    if (dict[input[i]] == curr)
                    {
                        chars.Pop();
                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }
            Console.WriteLine("YES");
        }
    }
}
