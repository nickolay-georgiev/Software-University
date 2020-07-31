using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rowls = size[0];
            int cols = size[1];

            string[,] matrix = new string[rowls, cols];
            int counter = 0;
            string input = Console.ReadLine();

            for (int i = 0; i < rowls; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i % 2 == 0)
                    {
                        matrix[i, j] = input[counter].ToString();
                        counter++;
                        if (counter == input.Length)
                        {
                            counter = 0;
                        }
                    }

                    else
                    {
                        int additionalCounter = 1;
                        for (int k = matrix.GetLength(1) - 1; k >= 0; k--)
                        {
                            matrix[i, matrix.GetLength(1) - additionalCounter] = input[counter].ToString();
                            counter++;
                            if (counter == input.Length)
                            {
                                counter = 0;
                            }
                            additionalCounter++;
                        }
                        break;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
