using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegexExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var regex = @"([@#])(?<first>[A-Za-z]{3,})\1\1(?<second>[A-Za-z]{3,})\1";
            var matches = Regex.Matches(word, regex);
            List<string> output = new List<string>();
            foreach (Match item in matches)
            {
                var firstWord = item.Groups["first"].Value;
                var secondWord = item.Groups["second"].Value;
                var secondWordReversed = string.Empty;
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    secondWordReversed += secondWord[i];
                }
                if (firstWord == secondWordReversed)
                {
                    output.Add($"{firstWord} <=> {secondWord}");
                }
            }
            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                if (output.Count > 0)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", output));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
            else
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
