using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = nums[j];
                }
            }

            int firstSum = 0;
            int secondSum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    firstSum += matrix[i, j + i];
                    secondSum += matrix[i, matrix.GetLength(1) - i - 1];
                    break;
                }
            }

            Console.WriteLine(Math.Abs(firstSum - secondSum));
        }
    }
}
