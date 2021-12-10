using System;
using System.Collections.Generic;
using System.Linq;
namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> student = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            int counter = 1;
            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (student.ContainsKey(studentName))
                {
                    counter++;
                    student[studentName][0] += studentGrade;
                    student[studentName][0] /= counter;
                    counter = 1;
                }
                else
                {
                    student.Add(studentName, new List<double>() { studentGrade });
                }
            }
            foreach (var person in student.OrderByDescending(x => x.Value[0]).ToList())
            {
                if (person.Value[0] >= 4.50)
                {
                    Console.WriteLine(string.Join("\n", $"{person.Key} -> {person.Value[0]:f2}"));
                }
            }
        }
    }
}
