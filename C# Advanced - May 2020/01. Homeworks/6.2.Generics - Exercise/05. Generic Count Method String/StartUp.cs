using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {                         
            int lines = int.Parse(Console.ReadLine());

            Box<string> box = new Box<string>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            string element = Console.ReadLine();

            int result = box.MyCompare(element);

            Console.WriteLine(result);
        }
        
        public static List<T> MySwap<T>(List<T> elements, int firstIndex, int secondIndex)
        {
            var myTemp = elements[firstIndex];

            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = myTemp;

            return elements;
        }
    }
}
