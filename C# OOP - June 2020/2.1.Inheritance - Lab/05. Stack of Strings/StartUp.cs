using System;
using System.Collections.Generic;

namespace CustomStack
{
    public class StartUp
    {
        public static void Main()
        {
            StackOfStrings test = new StackOfStrings();
            test.Push("AAA");

            Stack<string> temp = new Stack<string>();

            temp.Push("1");
            temp.Push("2");
            temp.Push("3");
            temp.Push("4");


            test.AddRange(temp);

            Console.WriteLine(test.IsEmpty());
            Console.WriteLine(string.Join(" ", test));
        }
    }
}
