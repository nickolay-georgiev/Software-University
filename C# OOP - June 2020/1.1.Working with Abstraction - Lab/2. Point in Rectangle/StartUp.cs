using System;
using System.Linq;

namespace Abstractions
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rectangleData = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int topLeftX = rectangleData[0];
            int topLeftY = rectangleData[1];
            Point leftXY = new Point(topLeftX, topLeftY);

            int bottomRightX = rectangleData[2];
            int bottomRightY = rectangleData[3];
            Point rightXY = new Point(bottomRightX, bottomRightY);

            Rectangle rectangle = new Rectangle(leftXY, rightXY);

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                int[] coordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x = coordinates[0];
                int y = coordinates[1];

                Console.WriteLine(rectangle.Contains(new Point(x, y)));
            }

        }
    }
}
