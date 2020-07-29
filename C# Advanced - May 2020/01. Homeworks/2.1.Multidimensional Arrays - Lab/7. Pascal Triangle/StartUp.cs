using System;

namespace _7._Pascal_Triangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            long n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];
            pascal[0] = new long[1];
            pascal[0][0] = 1;

            for (int row = 1; row < pascal.Length; row++)
            {
                pascal[row] = new long[row + 1];
                pascal[row][0] = 1;
                pascal[row][pascal[row].Length - 1] = 1;

                for (int col = 1; col < pascal[row].Length - 1; col++)
                {

                    pascal[row][col] = pascal[row - 1][col] + pascal[row - 1][col - 1];
                }
            }

            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
