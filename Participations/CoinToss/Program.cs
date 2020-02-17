//Peyton Kassing
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Heads or Tails? >>");
            string guess = Console.ReadLine();
            int userGuess = -1;
            const int headsValue = 0;
            const int tailsValue = 1;

            if (guess == "Heads")
            {
                userGuess = headsValue;
            }
            else if (guess == "Tails")
            {
                userGuess = tailsValue;
            }
            else
            {
                Console.WriteLine("That is not a valid guess, try again!");
            }

            Random rand = new Random();
            int randomNum = rand.Next(0, 2);

            if (userGuess == randomNum)
            {
                Console.WriteLine("You Won!!");
            }
            else
            {
                Console.WriteLine("You Lost...");
            }

            const string name = "Peyton Kassing";
                Console.WriteLine(name);

            Console.ReadKey(); 
        }
    }
}
