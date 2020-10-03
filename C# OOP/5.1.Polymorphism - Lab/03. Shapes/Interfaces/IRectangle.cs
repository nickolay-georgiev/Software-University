using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes.Interfaces
{
    public interface IRectangle : IShape
    {
        public double Height { get;}

        public double Width { get;}
    }
}
