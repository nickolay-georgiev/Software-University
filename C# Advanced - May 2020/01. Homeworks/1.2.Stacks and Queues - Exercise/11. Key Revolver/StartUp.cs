using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Key_Revolver
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var sizeGunBarrel = int.Parse(Console.ReadLine());
            var bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var valueOfIntellegence = int.Parse(Console.ReadLine());

            var bulletStack = new Stack<int>(bullets); //going through the bullet back-to-front. In this case use LIFO
            var locksQueue = new Queue<int>(locks); //shoot the lock from front-to-back. In this case use FIFO
            var usedBullets = 0; //it is for counting of used bullets
            var barrelCount = 0; //it is for checking when Sam need to reload

            while (bulletStack.Any() && locksQueue.Any())
            {
                if (bulletStack.Peek() <= locksQueue.Peek()) //First Case if the bullet <= lock
                {
                    Console.WriteLine("Bang!");
                    locksQueue.Dequeue();  //remove the lock
                    bulletStack.Pop(); //remove the bullet
                }
                else
                {
                    Console.WriteLine("Ping!");
                    bulletStack.Pop();

                }

                barrelCount++;

                if (barrelCount == sizeGunBarrel && bulletStack.Any())
                {
                    Console.WriteLine("Reloading!");
                    barrelCount = 0;
                }

                usedBullets++;
            }

            if (bulletStack.Count >= 0 && locksQueue.Count == 0)
            {
                var earn = valueOfIntellegence - (usedBullets * bulletPrice);
                Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${earn}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locksQueue.Count}");
            }
        }
    }
}
