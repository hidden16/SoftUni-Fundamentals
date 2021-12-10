using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" : ");
                if (input[0] == "end")
                {
                    break;
                }
                string courseName = input[0];
                string studentName = input[1];
                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses.Add(courseName, new List<string>() { studentName });
                }
            }
            foreach (var course in courses.OrderByDescending(x => x.Value.Count).ToList())
            {
                Console.WriteLine(string.Join("\n", $"{course.Key}: {course.Value.Count}"));
                for (int i = 0; i < course.Value.Count; i++)
                {
                    course.Value.Sort();
                    Console.WriteLine(string.Join("\n", $"-- {course.Value[i]}"));
                }
            }
        }
    }
}
