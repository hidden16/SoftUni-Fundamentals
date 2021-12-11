using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameRegex = @"(?<name>[a-zA-Z\s])";
            var pointsRegex = @"(?<points>[0-9])";
            string[] participants = Console.ReadLine().Split(", ");
            StringBuilder name = new StringBuilder();
            Dictionary<string, double> result = new Dictionary<string, double>();
            int points = 0;
            while (true)
            {

                string word = Console.ReadLine();
                if (word == "end of race")
                {
                    break;
                }
                var matchingName = Regex.Matches(word, nameRegex);
                foreach (Match item in matchingName)
                {
                    name.Append(item);
                }
                var matchingPoints = Regex.Matches(word, pointsRegex);
                foreach (Match item in matchingPoints)
                {
                    points += int.Parse(item.ToString());
                }
                if (participants.Contains(name.ToString()))
                {
                    if (result.ContainsKey(name.ToString()))
                    {
                        result[name.ToString()] += points;
                    }
                    else
                    {
                        result.Add(name.ToString(), points);
                    }
                }
                name.Clear();
                points = 0;
            }
            result = result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            result = result.Take(3).ToDictionary(x => x.Key, x => x.Value);
            int counter = 1;
            foreach (var item in result)
            {
                if (counter == 1)
                {
                    Console.WriteLine($"{counter}st place: {item.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"{counter}nd place: {item.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"{counter}rd place: {item.Key}");
                }
                counter++;
            }
        }
    }
}
