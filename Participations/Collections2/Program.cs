using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
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
