using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            Toy toy1 = new Toy();
            toy1.Manufacturer = "Nerf";
            toy1.Name = "Dart Blaster";
            toy1.Price = 19.99;
            GetAisle(toy1);

            Toy toy2 = new Toy();
            toy2.Manufacturer = "Hot Wheels";
            toy2.Name = "Race Car Track";
            toy2.Price = 59.99;
            GetAisle(toy2);

            ToyBox box1 = new ToyBox();
            box1.Toys.Add(toy1);

            ToyBox box2 = new ToyBox();
            box2.Toys.Add(toy2);

            Console.ReadKey();
        }
        static string GetAisle(Toy t)
        {
            Random rand = new Random();
            int r = rand.Next(1, 25);
            string first = t.Manufacturer.Substring(0,1);
            Console.WriteLine(first + r);
            string Meep = Console.ReadLine();
            return Meep;
        }
    }
}
