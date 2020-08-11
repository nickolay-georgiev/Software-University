using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int nameLenght = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> pred = x => x.Length <= nameLenght;

            var result = input.Where(x => pred(x));

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
