using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Even_Times
{
    class StartUp
    {
        static void Main(string[] args)
        {
            HashSet<string> allElements = new HashSet<string>();
            Dictionary<int, double> result = new Dictionary<int, double>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!result.ContainsKey(number))
                {
                    result.Add(number, 0);
                }
                result[number]++;
            }

            var theWinningNum = result.Select(x => x).Where(a => a.Value % 2 == 0).ToDictionary(x => x.Key, b => b.Value);

            Console.WriteLine($"{string.Join("", theWinningNum.Keys)}");
        }
    }
}
