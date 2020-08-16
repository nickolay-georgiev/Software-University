using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Family family = new Family();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var name = input[0];
                var age = int.Parse(input[1]);
                var person = new Person(name, age);
                family.AddMember(person);

            }

            Console.WriteLine(family.GetOldestMember());
        }
    }
}
