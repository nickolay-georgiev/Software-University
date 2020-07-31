using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = parameters[0];
            int cols = parameters[1];
            char[,] matrix = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                char[] input = Console.ReadLine().ToCharArray().
                    Where(x => !x.Equals(' ')).
                    ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int counter = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j].Equals(matrix[i, j + 1]) &&
                        matrix[i, j].Equals(matrix[i + 1, j + 1]) &&
                        matrix[i, j].Equals(matrix[i + 1, j]))
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
