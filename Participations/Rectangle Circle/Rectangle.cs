using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Circle
{
    class Rectangle
    {
        public double Length { get; set; }
        
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public Rectangle(double l, double w)
        {
            Length = l;
            Width = w;
        }

        public double CalculateArea()
        {
            return Length * Width;
        }

        public double CalculatePerimeter()
        {
            return (Length * 2) + (Width * 2);
        }
    }
}
