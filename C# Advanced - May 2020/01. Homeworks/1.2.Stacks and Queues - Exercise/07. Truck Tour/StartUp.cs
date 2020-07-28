using System;
using System.Linq;

namespace _07._Truck_Tour
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var startIndex = 0;
            var truckFuel = 0;

            for (int i = 0; i < n; i++)
            {
                var pipeData = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                truckFuel += pipeData[0] - pipeData[1];

                if (truckFuel < 0)
                {
                    truckFuel = 0;
                    startIndex = i + 1;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
