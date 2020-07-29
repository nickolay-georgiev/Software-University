using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
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

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }

                string[] commands = input.Split();
                string command = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int number = int.Parse(commands[3]);

                if (row >= matrix.GetLength(0) || row < 0 || col < 0 || col >= matrix.GetLength(1))
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                switch (command)
                {
                    case "Add":
                        matrix[row, col] += number;
                        break;

                    case "Subtract":
                        matrix[row, col] -= number;
                        break;
                }
            }

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
