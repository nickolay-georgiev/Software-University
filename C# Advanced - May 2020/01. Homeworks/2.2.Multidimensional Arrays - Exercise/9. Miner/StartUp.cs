using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Miner
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            string[] inputCommands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Queue<string> commands = new Queue<string>(inputCommands);

            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] field = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = field[col];

                    if (field[col].Equals('s'))
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            matrix[startRow, startCol] = '*';

            int collectedCoals = 0;
            while (commands.Count > 0)
            {
                string currentCommand = commands.Dequeue();

                switch (currentCommand)
                {
                    case "down":
                        if (IsCellIsInMatrixRange(matrix, startRow + 1, startCol))
                        {
                            if (matrix[startRow + 1, startCol].Equals('c'))
                            {
                                collectedCoals++;
                                matrix[startRow + 1, startCol] = '*';

                            }
                            else if (matrix[startRow + 1, startCol].Equals('e'))
                            {
                                Console.WriteLine($"Game over! ({startRow + 1}, {startCol})");
                                matrix[startRow + 1, startCol] = 's';
                                return;
                            }

                            startRow += 1;
                        }
                        break;

                    case "right":
                        if (IsCellIsInMatrixRange(matrix, startRow, startCol + 1))
                        {
                            if (matrix[startRow, startCol + 1].Equals('c'))
                            {
                                collectedCoals++;
                                matrix[startRow, startCol + 1] = '*';

                            }
                            else if (matrix[startRow, startCol + 1].Equals('e'))
                            {
                                Console.WriteLine($"Game over! ({startRow}, {startCol + 1})");
                                matrix[startRow, startCol + 1] = 's';
                                return;
                            }
                            startCol += 1;

                        }
                        break;

                    case "up":
                        if (IsCellIsInMatrixRange(matrix, startRow - 1, startCol))
                        {
                            if (matrix[startRow - 1, startCol].Equals('c'))
                            {
                                collectedCoals++;
                                matrix[startRow - 1, startCol] = '*';

                            }
                            else if (matrix[startRow - 1, startCol].Equals('e'))
                            {
                                Console.WriteLine($"Game over! ({startRow - 1}, {startCol})");
                                matrix[startRow - 1, startCol] = 's';
                                return;
                            }

                            startRow -= 1;
                        }
                        break;

                    case "left":
                        if (IsCellIsInMatrixRange(matrix, startRow, startCol - 1))
                        {
                            if (matrix[startRow, startCol - 1].Equals('c'))
                            {
                                collectedCoals++;
                                matrix[startRow, startCol - 1] = '*';

                            }
                            else if (matrix[startRow, startCol - 1].Equals('e'))
                            {
                                Console.WriteLine($"Game over! ({startRow}, {startCol - 1})");
                                matrix[startRow, startCol - 1] = 's';
                                return;
                            }
                            startCol -= 1;
                        }
                        break;
                }

                bool isThereAnyCoalsLeft = false;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col].Equals('c'))
                        {
                            isThereAnyCoalsLeft = true;
                        }
                    }
                }

                if (!isThereAnyCoalsLeft)
                {
                    Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                    matrix[startRow, startCol] = 's';
                    return;
                }
            }

            int coalsLeftCounter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].Equals('c'))
                    {
                        coalsLeftCounter++;
                    }
                }
            }

            matrix[startRow, startCol] = 's';
            Console.WriteLine($"{coalsLeftCounter} coals left. ({startRow}, {startCol})");
        }

        private static bool IsCellIsInMatrixRange(char[,] matrix, int row, int col)
        {
            if (0 <= row && row < matrix.GetLength(0) && 0 <= col && col < matrix.GetLength(1))
            {
                return true;
            }

            return false;
        }

        private static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
