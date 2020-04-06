using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Student1
{
    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<string> CourseNames { get; set; }

        public List<string> CourseGrades { get; set; }

        public Student()
        {
            FirstName = "Peyton";
            LastName = "Kassing";
            CourseNames = new List<string>();
            CourseGrades = new List<string>();
        }
        public Student(string first, string second)
        {
            FirstName = first;
            LastName = second;
            CourseNames = new List<string>();
            CourseGrades = new List<string>();
        }

        public double CalculateGPA()
        {
            double A = 4;
            double B = 3;
            double C = 2;
            double D = 1;
            double F = 0;

            if(CourseGrades.Contains("A"))
            {

            }

        }
    }
}
