using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _09._Simple_Text_Editor
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int countOfCommands = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>();
            StringBuilder builder = new StringBuilder();
            stack.Push(builder.ToString());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] input = Console.ReadLine().Split();
                int command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        string text = input[1];
                        builder.Append(text);
                        stack.Push(builder.ToString());

                        break;

                    case 2:
                        int count = int.Parse(input[1]);
                        builder = builder.Remove(builder.Length - count, count);
                        stack.Push(builder.ToString());
                        break;

                    case 3:
                        int index = int.Parse(input[1]);
                        char element = builder.ToString().ElementAt(index - 1);
                        Console.WriteLine(element);


                        break;

                    case 4:
                        stack.Pop();
                        builder.Clear();
                        builder.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}
