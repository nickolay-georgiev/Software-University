using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;

        private int height;

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width
        {
            get { return Width; }
            private set { Width = value; }
        }

        public int Height
        {
            get { return height; }
            private set { height = value; }
        }

        public void Draw()
        {
            Console.WriteLine(new string('*', this.Width));

            for (int i = 0; i < this.Height - 2; i++)
            {
                Console.WriteLine(new string('*', 1) + new string(' ', this.Width - 2) + new string('*', 1));
            }

            Console.WriteLine(new string('*', this.Width));
        }
    }
}
