using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }

                string[] command = input.Split(", ").ToArray();
                string action = command[0];
                string carNumber = command[1];

                switch (action)
                {
                    case "IN":
                        cars.Add(carNumber);
                        break;

                    case "OUT":
                        cars.Remove(carNumber);
                        break;
                }
            }

            if (cars.Count != 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car}");
                }
            }
            else
            {
                Console.WriteLine($"Parking Lot is Empty");
            }
        }
    }
}
