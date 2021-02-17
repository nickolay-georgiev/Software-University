using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public class Rectangle : Shape, IRectangle
    {
        private double height;
        private double width;

        public Rectangle(double heiht, double width)
        {
            this.Height = heiht;
            this.Width = width;
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.height = value;
            }
        }

        public double Width
        {
            get { return this.width; }
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.width = value; 
            }
        }

        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * this.Width + 2 * this.Height;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
