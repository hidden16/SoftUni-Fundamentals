using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace FinalExamExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"^(\$|\%)(?<tag>[A-Z][a-z]{2,})\1: \[(?<first>[\d]+)\]\|\[(?<second>[\d]+)\]\|\[(?<third>[\d]+)\]\|$";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var match = Regex.Match(input, regex);
                if (match.Success)
                {
                    var tag = match.Groups["tag"].Value;
                    var first = int.Parse(match.Groups["first"].Value);
                    var second = int.Parse(match.Groups["second"].Value);
                    var third = int.Parse(match.Groups["third"].Value);
                    char firstChar = (char)first;
                    var intFirst = firstChar;
                    char secondChar = (char)second;
                    var intSecond = secondChar;
                    char thirdChar = (char)third;
                    var intThird = thirdChar;
                    Console.WriteLine($"{tag}: {intFirst}{intSecond}{intThird}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
