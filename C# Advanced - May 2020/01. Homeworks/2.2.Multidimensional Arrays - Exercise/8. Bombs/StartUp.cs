using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Bombs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[][] matrix = new int[size][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new int[numbers.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = numbers[col];
                }
            }

            string input = Console.ReadLine();
            Queue<int> coordinates = new Queue<int>();

            foreach (var @char in input)
            {
                if (char.IsDigit(@char))
                {
                    coordinates.Enqueue(@char - '0');
                }
            }

            while (coordinates.Count > 0)
            {
                int row = coordinates.Dequeue();
                int col = coordinates.Dequeue();

                if (IsCellInMatrix(matrix, row + 1, col))
                {
                    if (IsNotADeadCell(matrix, row + 1, col))
                    {
                        matrix[row + 1][col] -= matrix[row][col];
                    }
                }
                if (IsCellInMatrix(matrix, row + 1, col + 1))
                {
                    if (IsNotADeadCell(matrix, row + 1, col + 1))
                    {
                        matrix[row + 1][col + 1] -= matrix[row][col];
                    }
                }
                if (IsCellInMatrix(matrix, row, col + 1))
                {
                    if (IsNotADeadCell(matrix, row, col + 1))
                    {
                        matrix[row][col + 1] -= matrix[row][col];
                    }
                }
                if (IsCellInMatrix(matrix, row - 1, col + 1))
                {
                    if (IsNotADeadCell(matrix, row - 1, col + 1))
                    {
                        matrix[row - 1][col + 1] -= matrix[row][col];
                    }
                }
                if (IsCellInMatrix(matrix, row - 1, col))
                {
                    if (IsNotADeadCell(matrix, row - 1, col))
                    {
                        matrix[row - 1][col] -= matrix[row][col];
                    }
                }
                if (IsCellInMatrix(matrix, row - 1, col - 1))
                {
                    if (IsNotADeadCell(matrix, row - 1, col - 1))
                    {
                        matrix[row - 1][col - 1] -= matrix[row][col];
                    }
                }
                if (IsCellInMatrix(matrix, row, col - 1))
                {
                    if (IsNotADeadCell(matrix, row, col - 1))
                    {
                        matrix[row][col - 1] -= matrix[row][col];
                    }
                }
                if (IsCellInMatrix(matrix, row + 1, col - 1))
                {
                    if (IsNotADeadCell(matrix, row + 1, col - 1))
                    {
                        matrix[row + 1][col - 1] -= matrix[row][col];
                    }
                }

                matrix[row][col] = 0;
            }

            int counter = 0;
            int sum = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        sum += matrix[row][col];
                        counter++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {counter}" + Environment.NewLine + $"Sum: {sum}");
            PrintMatrix(matrix);
        }

        private static bool IsNotADeadCell(int[][] matrix, int row, int col)
        {
            return matrix[row][col] > 0;
        }

        private static bool IsCellInMatrix(int[][] matrix, int row, int col)
        {
            if (0 <= row && row < matrix.Length && 0 <= col && col < matrix[row].Length)
            {
                return true;
            }

            return false;
        }

        private static void PrintMatrix(int[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

