using System;
using System.Linq;
using System.Collections.Generic;

namespace _12._Cups_and_Bottles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] bottlesWithWater = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int wastedWater = 0;

            Queue<int> cups = new Queue<int>(cupsCapacity);
            Stack<int> bottles = new Stack<int>(bottlesWithWater);

            bool isSomeWaterLeft = false;
            int waterToAdd = 0;
            while (cups.Count > 0 && bottles.Count > 0)
            {
                int currentCup = cups.Peek();
                int currentBottle = bottles.Pop();

                if (isSomeWaterLeft)
                {
                    currentCup = waterToAdd;
                    isSomeWaterLeft = false;
                }

                if (currentBottle - currentCup >= 0)
                {
                    wastedWater += currentBottle - currentCup;
                    cups.Dequeue();
                }
                else
                {
                    waterToAdd = currentCup - currentBottle;
                    isSomeWaterLeft = true;
                }
            }
        }
    }
}
