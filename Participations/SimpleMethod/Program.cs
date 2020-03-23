using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal;
            string sound = "";

            Console.WriteLine("Please enter a type of animal (cow, pig, chicken).");
            animal = Console.ReadLine().ToLower();

            sound = Speak(animal);
            Console.WriteLine(sound);


            Console.ReadKey();
        }
        static string Speak(string animal)
        {
            string sound = "";
            if (animal == "cow")
            {
                sound = "Moo";
               
            }
            else if (animal == "pig")
            {
                sound = "Oink";
            }
            else if (animal == "chicken")
            {
                sound = "Cockadoodaldoo";
            }
            return sound;
        }
    }
}
