using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] parameters = Console.ReadLine()
               .Split(", ")
               .Select(int.Parse)
               .ToArray();

            int rows = parameters[0];
            int cols = parameters[1];

            int[,] matrix = new int[rows, cols];
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbers[j];
                    sum += numbers[j];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
