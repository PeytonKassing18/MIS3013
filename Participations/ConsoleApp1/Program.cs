using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static string msg = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

        static void Main(string[] args)
        {
            String lookupWord;
            String replaceWord;
            Console.WriteLine(msg);

            Console.WriteLine("What word do you want to look for?");
            lookupWord = Console.ReadLine();

            Console.WriteLine("What do you want to change " + lookupWord + " to?");
            replaceWord = Console.ReadLine();

            bool wordPresent = msg.Contains(lookupWord);
            
            if (wordPresent == true)
            {
                Console.WriteLine(msg.Replace(lookupWord, replaceWord));
            }
            else
            {
                Console.WriteLine("Sorry, I could not find your word, " + lookupWord + ".");
                for (int i = lookupWord.Length - 1; i >= 0; i--)
                {
                    Console.Write(lookupWord[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
