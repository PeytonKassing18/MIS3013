using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rectangle> rectangles = new List<Rectangle>();
            double l, w;

            List<Circle> circles = new List<Circle>();
            double ra;

            l = 5;
            w = 6;

            ra = 7;

            Rectangle Rect1 = new Rectangle();
            Rect1.Length = 10;
            Rect1.Width = 12;
            rectangles.Add(Rect1);

            Rectangle Rect2 = new Rectangle(l, w);
            rectangles.Add(Rect2);

            Circle Circ1 = new Circle();
            Circ1.Radius = 11;
            circles.Add(Circ1);

            Circle Circ2 = new Circle(ra);
            circles.Add(Circ2);

            foreach (var rectangle in rectangles)
            {
                OutputCalculationsOfRectangle(rectangle);
            }

            foreach (var circle in circles)
            {
                OutputCalculationsOfCircle(circle);
            }

            Console.ReadKey();
        }

        static void OutputCalculationsOfRectangle(Rectangle r)
        {
            Console.WriteLine($"The rectangle with {r.Length} length and {r.Width} width has an area of {r.CalculateArea()} and a perimeter of {r.CalculatePerimeter()}");
        }

        static void OutputCalculationsOfCircle(Circle c)
        {
            Console.WriteLine($"The circle with {c.Radius} radius has an area of {c.CalculateArea()} and a perimeter of {c.CalculatePerimeter()}");
        }
    }
}
