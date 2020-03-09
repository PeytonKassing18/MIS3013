using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxAvg
{
    class Program
    {
        static void Main(string[] args)
        {
            double examGrade;
            string answer = "Yes";
            double avg;
            double sum = 0;
            List<double> total = new List<double>();
            do
            {
                Console.WriteLine("What is your exam grade");
                examGrade = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Do you have another exam grade to add?");
                answer = Console.ReadLine();
                total.Add(examGrade);
            }
            while (answer == "Yes");

            for (int i = 0; i < total.Count; i++)
            {
                sum += total[i];
            }
            avg = sum / total.Count;
            Console.WriteLine("Your average is " + avg);

            double max = total[0];
            double min = total[0];
            for (int i = 0; i < total.Count; i++)
            {
                if (max < total[i])
                    max = total[i];
                if (min > total[i])
                    min = total[i];
            }

            Console.WriteLine("Your max is " + max);
            Console.WriteLine("Your min is " + min);

            Console.ReadKey();
        }
    }
}
