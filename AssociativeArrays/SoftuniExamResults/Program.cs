using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniExamProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> students = new Dictionary<string, int>();
            Dictionary<string, int> languageAndSubmissions = new Dictionary<string, int>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exam finished")
                {
                    break;
                }
                string[] token = input.Split("-");
                string username = token[0];
                string language = token[1];
                if (token[1] == "banned")
                {
                    students.Remove(username);
                }
                else if (students.ContainsKey(username))
                {
                    int points = int.Parse(token[2]);
                    if (students[username] < points)
                    {
                        students[username] = points;
                    }
                }
                else
                {
                    int points = int.Parse(token[2]);
                    students.Add(username, points);
                }
                if (languageAndSubmissions.ContainsKey(language))
                {
                    languageAndSubmissions[language]++;
                }
                else if (token[1] != "banned")
                {
                    languageAndSubmissions.Add(language, 1);
                }

            }
            Console.WriteLine("Results:");
            foreach (var student in students.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList())
            {
                Console.WriteLine(string.Join("\n", $"{student.Key} | {student.Value}"));
            }
            Console.WriteLine("Submissions:");
            foreach (var submission in languageAndSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList())
            {
                Console.WriteLine(string.Join("\n", $"{submission.Key} - {submission.Value}"));
            }
        }
    }
}
