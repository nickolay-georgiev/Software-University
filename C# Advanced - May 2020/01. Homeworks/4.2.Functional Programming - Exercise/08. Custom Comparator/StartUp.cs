using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] dividers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            Func<int, int, int> myComparer = (a, b) =>
            {
                if (a % 2 == 0 && b % 2 == 0)
                {
                    if (a < b)
                    {
                        return -1;
                    }
                    if (a > b)
                    {
                        return 1;
                    }

                    return 0;

                }
                if (a % 2 != 0 && b % 2 != 0)
                {
                    if (a < b)
                    {
                        return -1;
                    }

                    if (a > b)
                    {
                        return 1;
                    }

                    return 0;
                }

                if (a % 2 == 0)
                {
                    return -1;
                }

                if (a % 2 != 0)
                {
                    return 1;
                }

                return 0;
            };

            Array.Sort(dividers, new Comparison<int>(myComparer));

            Console.WriteLine(string.Join(" ", dividers));
        }
    }
}
