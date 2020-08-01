using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Radioactive_Mutant_Vampire_Bunnies
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] fieldSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = fieldSize[0];
            int cols = fieldSize[1];
            char[,] matrix = new char[rows, cols];

            int row = 0;
            int col = 0;
            Queue<int> bunniesPositions = new Queue<int>();

            for (int currentRow = 0; currentRow < matrix.GetLength(0); currentRow++)
            {
                string input = Console.ReadLine();

                for (int currentCol = 0; currentCol < matrix.GetLength(1); currentCol++)
                {
                    matrix[currentRow, currentCol] = input[currentCol];

                    if (matrix[currentRow, currentCol].Equals('P'))
                    {
                        row = currentRow;
                        col = currentCol;
                        matrix[currentRow, currentCol] = '.';
                    }
                    else if (matrix[currentRow, currentCol].Equals('B'))
                    {
                        bunniesPositions.Enqueue(currentRow);
                        bunniesPositions.Enqueue(currentCol);
                    }
                }
            }

            string inputCommands = Console.ReadLine();
            Queue<char> commands = new Queue<char>(inputCommands);

            bool isPlayerDead = false;
            bool isPlayerWinning = false;

            while (commands.Count > 0)
            {
                char command = commands.Dequeue();
                matrix[row, col] = '.';


                if (command.Equals('U'))
                {
                    if (IsCellIsInMatrixRange(matrix, row - 1, col))
                    {
                        if (matrix[row - 1, col].Equals('B'))
                        {
                            isPlayerDead = true;
                        }

                        row -= 1;
                    }
                    else
                    {
                        isPlayerWinning = true;
                    }

                }
                else if (command.Equals('R'))
                {
                    if (IsCellIsInMatrixRange(matrix, row, col + 1))
                    {
                        if (matrix[row, col + 1].Equals('B'))
                        {
                            isPlayerDead = true;
                        }

                        col += 1;
                    }
                    else
                    {
                        isPlayerWinning = true;
                    }
                }
                else if (command.Equals('D'))
                {
                    if (IsCellIsInMatrixRange(matrix, row + 1, col))
                    {
                        if (matrix[row + 1, col].Equals('B'))
                        {
                            isPlayerDead = true;
                        }

                        row += 1;
                    }
                    else
                    {
                        isPlayerWinning = true;
                    }
                }
                else if (command.Equals('L'))
                {
                    if (IsCellIsInMatrixRange(matrix, row, col - 1))
                    {
                        if (matrix[row, col - 1].Equals('B'))
                        {
                            isPlayerDead = true;
                        }
                        col -= 1;
                    }
                    else
                    {
                        isPlayerWinning = true;
                    }

                }

                if (isPlayerDead)
                {
                    matrix[row, col] = 'B';
                }
                else if (isPlayerWinning)
                {
                    matrix[row, col] = '.';
                }
                else
                {
                    matrix[row, col] = 'P';
                }

                while (bunniesPositions.Count > 0)
                {
                    int bunnyRow = bunniesPositions.Dequeue();
                    int bunnyCol = bunniesPositions.Dequeue();

                    if (IsCellIsInMatrixRange(matrix, bunnyRow - 1, bunnyCol))
                    {
                        if (matrix[bunnyRow - 1, bunnyCol].Equals('P'))
                        {
                            isPlayerDead = true;
                        }
                        matrix[bunnyRow - 1, bunnyCol] = 'B';
                    }
                    if (IsCellIsInMatrixRange(matrix, bunnyRow, bunnyCol + 1))
                    {
                        if (matrix[bunnyRow, bunnyCol + 1].Equals('P'))
                        {
                            isPlayerDead = true;
                        }
                        matrix[bunnyRow, bunnyCol + 1] = 'B';
                    }
                    if (IsCellIsInMatrixRange(matrix, bunnyRow + 1, bunnyCol))
                    {
                        if (matrix[bunnyRow + 1, bunnyCol].Equals('P'))
                        {
                            isPlayerDead = true;
                        }
                        matrix[bunnyRow + 1, bunnyCol] = 'B';
                    }
                    if (IsCellIsInMatrixRange(matrix, bunnyRow, bunnyCol - 1))
                    {
                        if (matrix[bunnyRow, bunnyCol - 1].Equals('P'))
                        {
                            isPlayerDead = true;
                        }
                        matrix[bunnyRow, bunnyCol - 1] = 'B';
                    }
                }

                if (isPlayerDead)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {row} {col}");
                    return;
                }
                else if (isPlayerWinning)
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {row} {col}");
                    return;
                }

                for (int currRow = 0; currRow < matrix.GetLength(0); currRow++)
                {
                    for (int currCol = 0; currCol < matrix.GetLength(1); currCol++)
                    {
                        if (matrix[currRow, currCol].Equals('B'))
                        {
                            bunniesPositions.Enqueue(currRow);
                            bunniesPositions.Enqueue(currCol);
                        }
                    }
                }
            }


            Console.WriteLine();
            PrintMatrix(matrix);
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
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}

