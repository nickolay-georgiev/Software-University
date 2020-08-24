using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] input1 = Console.ReadLine().Split();
            string name1 = input1[0] + " " + input1[1];
            string country = input1[2];

            Tuple<string, string> myTuple1 = new Tuple<string, string>(name1, country);

            string[] input2 = Console.ReadLine().Split();
            string name2 = input2[0];
            int num = int.Parse(input2[1]);
            Tuple<string, int> myTuple2 = new Tuple<string, int>(name2, num);

            string[] input3 = Console.ReadLine().Split();
            int number = int.Parse(input3[0]);
            double liters = double.Parse(input3[1]);
            Tuple<int, double> myTuple3 = new Tuple<int, double>(number, liters);

            Console.WriteLine(myTuple1);
            Console.WriteLine(myTuple2);
            Console.WriteLine(myTuple3);


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
