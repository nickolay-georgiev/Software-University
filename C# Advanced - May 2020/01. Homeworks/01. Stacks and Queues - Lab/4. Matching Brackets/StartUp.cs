using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> indexes = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    int startIndex = i;
                    indexes.Push(startIndex);
                }
                else if (input[i] == ')')
                {
                    int startIndex = indexes.Pop();
                    string sub = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(sub);
                }
            }
        }
    }
}
