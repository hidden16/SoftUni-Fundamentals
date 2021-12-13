using System;
using System.Text.RegularExpressions;

namespace RegexExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"([|#])(?<name>[\sA-Za-z]+)\1(?<date>[\d]{2}\/[\d]{2}\/[\d]{2})\1(?<calories>[\d]{1,5})\1";
            var word = Console.ReadLine();
            var matches = Regex.Matches(word, regex);
            var calories = 0;
            foreach (Match item in matches)
            {
                calories += int.Parse(item.Groups["calories"].Value);
            }
            calories /= 2000;
            Console.WriteLine($"You have food to last you for: {calories} days!");
            foreach (Match item in matches)
            {
                var name = item.Groups["name"].Value;
                var date = item.Groups["date"].Value;
                var nutrition = int.Parse(item.Groups["calories"].Value);
                Console.WriteLine($"Item: {name}, Best before: {date}, Nutrition: {nutrition}");
            }
        }
    }
}
