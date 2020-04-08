using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2_Toys
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Aisle { get; set; }

        public string ToyAisle()
        {
            return Aisle;
        }

        public Toy()
        {
            Manufacturer = "Lego";
            Name = "Super Mario starter kit";
            Price = 29.99;
            Aisle = "Kids Toys";
        }
    }
}
