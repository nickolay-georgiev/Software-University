using System;
using System.Collections.Generic;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<string>();
                         
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            Console.WriteLine(box);
        }
    }
}
