using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            Stack<string> input = new Stack<string>();

            for (int i = 0; i < data.Length; i++)
            {
                input.Push(data[i].ToString());
            }

            Console.WriteLine(string.Join("", input));
        }
    }
}
