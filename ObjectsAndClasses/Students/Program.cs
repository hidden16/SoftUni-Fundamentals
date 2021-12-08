using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsObjAndClasExercise
{
    class Students
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grades { get; set; }

        public Students(string firstName, string lastName, double grades)
        {
            FirstName = firstName;
            LastName = lastName;
            Grades = grades;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grades:f2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Students> students = new List<Students>();
            for (int i = 1; i <= studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                var student = new Students(input[0], input[1], double.Parse(input[2]));
                students.Add(student);
            }
            students = students.OrderBy(x => x.Grades).ToList();
            students.Reverse();
            Console.WriteLine(string.Join("\n", students));
        }
    }
}
