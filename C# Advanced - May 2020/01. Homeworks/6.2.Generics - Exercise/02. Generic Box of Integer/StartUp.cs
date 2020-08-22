using System;
using System.Collections.Generic;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();
                         
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
            }

            Console.WriteLine(box);
        }
    }
}
