using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            Family family = new Family();
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                family.AddMember(new Person(name, age));
            }

            foreach (var person in family.People.OrderBy(x=>x.Name).Where(x=>x.Age > 30))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
