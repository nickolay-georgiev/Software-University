using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            int row = size[0];
            int col = size[1];

            string[,] matrix = new string[row, col];

            for (int i = 0; i < row; i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = input[j];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command.Equals("END"))
                {
                    break;
                }

                string[] coordinates = command.Split();

                if (coordinates[0] != "swap" || coordinates.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row1 = int.Parse(coordinates[1]);
                int col1 = int.Parse(coordinates[2]);
                int row2 = int.Parse(coordinates[3]);
                int col2 = int.Parse(coordinates[4]);

                if (row <= row1 || row1 < 0 || row <= row2 || row2 < 0 || col <= col1 || col1 < 0 || col <= col2 || col2 < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                string temp = matrix[row2, col2];
                matrix[row2, col2] = matrix[row1, col1];
                matrix[row1, col1] = temp;

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
