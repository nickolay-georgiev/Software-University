using System;
using System.Linq;

namespace _12._TriFunction
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> func = (name, length) => name.Sum(x => x) >= length;

            Func<string[], Func<string, int, bool>, int, string> myFunc = (names, func, length)
                => names.FirstOrDefault(x => func(x, length));


            int target = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            var result = myFunc(names, func, target);
            Console.WriteLine(result);
        }
    }
}
