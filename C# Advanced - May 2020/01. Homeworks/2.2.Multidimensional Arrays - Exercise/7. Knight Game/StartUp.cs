using System;

namespace _7._Knight_Game
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];


            for (int i = 0; i < size; i++)
            {
                char[] input = Console.ReadLine().ToCharArray();
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int removedKnights = 0;
            int counter = 0;
            int maxAttacks = 0;
            int attackerRow = 0;
            int attackerCol = 0;

            while (true)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col].Equals('K'))
                        {
                            try
                            {
                                if (matrix[row - 2, col - 1].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }
                            try
                            {
                                if (matrix[row - 2, col + 1].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                if (matrix[row + 1, col + 2].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                if (matrix[row + 1, col - 2].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                if (matrix[row - 1, col - 2].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                if (matrix[row - 1, col + 2].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                if (matrix[row + 2, col + 1].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }

                            try
                            {
                                if (matrix[row + 2, col - 1].Equals('K'))
                                {
                                    counter++;
                                }
                            }
                            catch
                            {

                            }
                        }

                        if (maxAttacks < counter)
                        {
                            maxAttacks = counter;
                            attackerRow = row;
                            attackerCol = col;
                        }
                        counter = 0;
                    }
                }

                if (maxAttacks != 0)
                {
                    matrix[attackerRow, attackerCol] = '0';
                    maxAttacks = 0;
                    removedKnights++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedKnights);
        }

        private static bool IsCellInMatrix(char[,] matrix, int row, int col)
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

