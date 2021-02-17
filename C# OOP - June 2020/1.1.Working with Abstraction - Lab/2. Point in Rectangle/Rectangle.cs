using System;
using System.Collections.Generic;
using System.Text;

namespace Abstractions
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }

        public bool Contains(Point point)
        {
            if (this.TopLeft.X <= point.X && point.X <= this.BottomRight.X && this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y)
            {
                return true;
            }

            return false;
        }
    }
}
