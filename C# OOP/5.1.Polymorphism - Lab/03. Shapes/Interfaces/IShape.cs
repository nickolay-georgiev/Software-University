using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Interfaces
{
    public interface IShape
    {
        double CalculatePerimeter();

        double CalculateArea();

        string Draw();
    }
}
