﻿using System;

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main()
        {
            try
            {

                double length = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Box box = new Box(length, width, height);

                Console.WriteLine(box);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
        }
    }
}
