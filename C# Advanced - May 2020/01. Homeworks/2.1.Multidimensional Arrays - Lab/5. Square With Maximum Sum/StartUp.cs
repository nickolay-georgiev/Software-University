using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[,] matrix = new int[n[0], n[1]];

            for (int i = 0; i < n[0]; i++)
            {
                int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int j = 0; j < n[1]; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            int maxSum = int.MinValue;
            int maxRol = 0;
            int maxCol = 0;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                int sum = 0;

                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRol = i;
                        maxCol = j;

                    }
                }            
            }

            Console.WriteLine($"{matrix[maxRol, maxCol]} {matrix[maxRol, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRol + 1, maxCol]} {matrix[maxRol + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
