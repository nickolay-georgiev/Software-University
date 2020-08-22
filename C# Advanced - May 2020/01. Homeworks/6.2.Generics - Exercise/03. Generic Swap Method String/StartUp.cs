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

            List<string> myList = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                myList.Add(input);
            }

            int[] swapIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstIndex = swapIndexes[0];
            int secondIndex = swapIndexes[1];

            myList = MySwap(myList, firstIndex, secondIndex);

            foreach (var element in myList)
            {
                Console.WriteLine($"{element.GetType()}: {element}");
            }
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
