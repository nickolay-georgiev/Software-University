using CollectionHierarchy.Models;
using System;
using System.Linq;

namespace CollectionHierarchy
{
    public class StartUp
    {
        static void Main()
        {
            AddCollection addColection = new AddCollection();
            AddRemoveCollection addRemoveCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            string[] input = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                string element = input[i];

                addColection.Add(element);
                addRemoveCollection.Add(element);
                myList.Add(element);
            }

            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                addRemoveCollection.Remove();
                myList.Remove();
            }

            Console.WriteLine(string.Join(" ", addColection.AddResult));
            Console.WriteLine(string.Join(" ", addRemoveCollection.AddResult));
            Console.WriteLine(string.Join(" ", myList.AddResult));
            Console.WriteLine(string.Join(" ", addRemoveCollection.RemoveResult));
            Console.WriteLine(string.Join(" ", myList.RemoveResult));

        }
    }
}
