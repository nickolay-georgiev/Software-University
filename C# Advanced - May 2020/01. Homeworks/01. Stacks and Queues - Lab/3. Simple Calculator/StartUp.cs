using System;
using System.Linq;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> numbers = new Stack<string>(input.Reverse());

            while (numbers.Count > 1)
            {
                int firstNumber = int.Parse(numbers.Pop());
                string @operator = numbers.Pop();
                int secondNumber = int.Parse(numbers.Pop());

                switch (@operator)
                {
                    case "+":
                        numbers.Push((firstNumber + secondNumber).ToString());
                        break;

                    case "-":
                        numbers.Push((firstNumber - secondNumber).ToString());
                        break;
                }
            }

            Console.WriteLine(numbers.Pop().ToString());
        }
    }
}
