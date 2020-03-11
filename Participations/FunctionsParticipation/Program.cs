using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsParticipation
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            Console.WriteLine("Which participation do you want to run (CoinToss, Collections2)?");
            answer = Console.ReadLine().ToLower();

            if (answer == "cointoss")
            {
                CoinToss();
            }
            else if (answer == "collections2")
            {
                Collections2();
            }

        }
        static void CoinToss()
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

        static void Collections2()
        {
            string[] classes = new string[3];
            int[] courseNum = new int[3];

            Console.WriteLine("Please enter information for three classes.");

            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine("Please enter a class.");
                classes[i] = Console.ReadLine();
                Console.WriteLine("Please enter the class course number.");
                courseNum[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < classes.Length; i++)
            {
                Console.WriteLine(classes[i] + courseNum[i]);
            }

            List<double> grades = new List<double>();

            Console.ReadKey();
        }


    }
}
