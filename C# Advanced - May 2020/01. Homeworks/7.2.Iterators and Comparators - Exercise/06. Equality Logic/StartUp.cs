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
            int lines = int.Parse(Console.ReadLine());

            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>();

            for (int i = 0; i < lines; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name = data[0];
                int age = int.Parse(data[1]);
                
                sortedSet.Add(new Person(name, age));
                hashSet.Add(new Person(name, age));
            }

            Console.WriteLine(sortedSet.Count);           
            Console.WriteLine(hashSet.Count);           
        }
    }
}
