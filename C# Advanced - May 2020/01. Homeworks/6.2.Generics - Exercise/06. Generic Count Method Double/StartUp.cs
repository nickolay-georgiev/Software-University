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

            Box<double> box = new Box<double>();

            for (int i = 0; i < lines; i++)
            {
                double input = double.Parse(Console.ReadLine());
                box.Add(input);
            }

            double element = double.Parse(Console.ReadLine());

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
