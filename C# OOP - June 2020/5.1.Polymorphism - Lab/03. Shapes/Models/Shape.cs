using Shapes.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Models
{
    public abstract class Shape : IShape
    {
        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
