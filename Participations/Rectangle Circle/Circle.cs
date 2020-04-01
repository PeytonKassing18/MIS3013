using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Circle
{
    class Circle
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public Circle(double ra)
        {
            Radius = ra;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }

        public double CalculatePerimeter()
        {
            return (2 * Math.PI) * Radius;
        }
    }
}
