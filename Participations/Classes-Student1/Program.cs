using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Student1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first, second;

            first = "Meep";
            second = "meow";

            Student student1 = new Student();
            student1.FirstName = "Grant";
            student1.LastName = "K";
            student1.CourseNames.Add("MIS3013");
            student1.CourseGrades.Add("A");
            student1.CourseNames.Add("MIS3213");
            student1.CourseGrades.Add("B");
            student1.CourseNames.Add("MKT3323");
            student1.CourseGrades.Add("C");
            student1.CourseNames.Add("SCM3223");
            student1.CourseGrades.Add("B");
            student1.CourseNames.Add("SCM3523");
            student1.CourseGrades.Add("A");

            Student student2 = new Student(first, second);
            student2.CourseNames.Add("MIS3013");
            student2.CourseGrades.Add("C");
            student1.CourseNames.Add("MIS3213");
            student1.CourseGrades.Add("A");
            student1.CourseNames.Add("MKT3323");
            student1.CourseGrades.Add("C");
            student1.CourseNames.Add("SCM3223");
            student1.CourseGrades.Add("D");
            student1.CourseNames.Add("SCM3523");
            student1.CourseGrades.Add("F");

            Console.ReadKey();
        }
    }
}
