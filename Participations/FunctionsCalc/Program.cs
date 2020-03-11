//Peyton Kassing
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            DeveloperInformation("Peyton Kassing", "MIS-3013", "03/09/2020");
            string calculation, answer, continueWith;
            double val1 = 0, val2 = 0, calc = 0;
            bool askForVal1 = true;
            do
            {
                Console.WriteLine("What type of calculation do you want to do (+, -, *, /)?");
                calculation = Console.ReadLine().ToLower();
                if (askForVal1 == true)
                {
                    Console.WriteLine("What is your first value?");
                    val1 = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("What is your second value?");
                val2 = double.Parse(Console.ReadLine());

                if (calculation == "+")
                {
                    calc = Add(val1, val2);
                }
                else if (calculation == "-")
                {
                    calc = Subtract(val1, val2);
                }
                else if (calculation == "*")
                {
                    calc = Multiply(val1, val2);
                }
                else if (calculation == "/")
                {
                    calc = Divide(val1, val2);
                }
                else
                {
                    Console.WriteLine("Please enter a valid calculation type.");
                }

                Console.WriteLine(val1 + " " + calculation + " " + val2 + " = " + calc);

                Console.WriteLine("Do you want to do a new calculation?");
                answer = Console.ReadLine().ToLower();

                if (answer == "yes")
                {
                    Console.WriteLine("Do you want to use the result of the previous calculation for your new calculations first value?");
                    continueWith = Console.ReadLine().ToLower();
                    if (continueWith == "yes")
                    {
                        val1 = calc;
                        askForVal1 = false;
                    }
                    else
                    {
                        askForVal1 = true;
                    }
                }

            }
            while (answer == "yes");

            Console.ReadKey();
        }
        
        static double Add(double first, double second)
        {
            return first + second;
        }

        static double Subtract(double first, double second)
        {
            return first - second;
        }

        static double Multiply(double first, double second)
        {
            return first * second;
        }
        
        static double Divide(double first, double second)
        {
            return first / second;
        }

        static void DeveloperInformation(string developerName, string className, string dateOfWriting)
        {
            Console.WriteLine(developerName + " wrote this application for " + className + " on " + dateOfWriting);
        }
    }
}
