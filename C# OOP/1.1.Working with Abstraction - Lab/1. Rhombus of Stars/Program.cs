using System;

namespace _1._Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                PrintRow(n, i);
            }

            for (int i = n - 2; i >= 0; i--)
            {
                PrintRow(n, i);
            }
        }

        private static void PrintRow(int n, int i)
        {
            for (int k = 0; k < n - i; k++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i + 1; j++)
            {
                Console.Write("*" + " ");
            }

            Console.WriteLine();
        }
    }
}
