using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    class StartUp
    {
        public static void Main()
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];

                if (name.Equals("END"))
                {
                    break;
                }

                int age = int.Parse(input[1]);
                string town = input[2];

                people.Add(new Person(name, age, town));
            }

            int number = int.Parse(Console.ReadLine());

            Person comaparerPerson = people[number - 1];

            int counter = 1;
            foreach (var person in people.Where(x=>x != comaparerPerson))
            {
                if (comaparerPerson.CompareTo(person) == 0)
                {
                    counter++;
                }
            }

            if (counter != 1)
            {
                Console.WriteLine($"{counter} {people.Count - counter} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
