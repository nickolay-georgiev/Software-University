using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        public static void Main()
        {

            RandomList list = new RandomList();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");

            var temp1 = list.RandomString();
            var temp2 = list.RemoveString();

            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
        }
    }
}
