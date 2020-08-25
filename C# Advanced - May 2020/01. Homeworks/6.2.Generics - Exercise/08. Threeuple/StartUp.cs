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
            string town = input1[3] + " " + string.Join(" ", input1.Skip(4));

            Threeuple<string, string, string> myTuple1 = new Threeuple<string, string, string>(name1, country, town);

            string[] input2 = Console.ReadLine().Split();
            string name2 = input2[0];
            int num = int.Parse(input2[1]);
            bool drunkOrNot = input2[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> myTuple2 = new Threeuple<string, int, bool>(name2, num, drunkOrNot);

            string[] input3 = Console.ReadLine().Split();
            string name3 = input3[0];
            double liters = double.Parse(input3[1]);
            string bankName = input3[2];
            Threeuple<string, double, string> myTuple3 = new Threeuple<string, double, string>(name3, liters, bankName);

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
