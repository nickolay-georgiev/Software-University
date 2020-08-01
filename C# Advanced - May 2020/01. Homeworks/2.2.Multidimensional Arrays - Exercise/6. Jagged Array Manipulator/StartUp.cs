using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            double[][] matrix = new double[rowsCount][];

            for (int row = 0; row < rowsCount; row++)
            {
                int[] nums = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = new double[nums.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = nums[col];
                }
            }

            MatrixAnalyzer(matrix);

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }

                string[] commands = input.Split();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);


                if (IsOutOfRange(matrix, row, col))
                {
                    continue;
                }

                switch (command)
                {
                    case "Add":
                        matrix[row][col] += value;
                        break;

                    case "Subtract":
                        matrix[row][col] -= value;
                        break;
                }

            }

            PrintMatrix(matrix);
        }

        private static bool IsOutOfRange(double[][] matrix, int row, int col)
        {
            return row < 0 || row >= matrix.GetLength(0) || col < 0 || col >= matrix[row].Length;
        }

        private static void PrintMatrix(double[][] matrix)
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

        private static void MatrixAnalyzer(double[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row].Length.Equals(matrix[row + 1].Length))
                    {
                        matrix[row][col] *= 2;
                        matrix[row + 1][col] *= 2;
                    }

                    else
                    {
                        int counter = 0;
                        foreach (var item in matrix[row])
                        {
                            matrix[row][counter++] /= 2;
                        }
                        counter = 0;
                        foreach (var item in matrix[row + 1])
                        {
                            matrix[row + 1][counter++] /= 2;
                        }
                        break;
                    }
                }
            }
        }
    }
}
