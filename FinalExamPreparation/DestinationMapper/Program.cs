using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DestinationMapper
{

    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var regex = @"([=\/])([A-Z][A-Za-z]{2,})\1";

            var matches = Regex.Matches(word, regex);

            StringBuilder sb = new StringBuilder();
            Console.Write($"Destinations: ");
            int i = 0;
            foreach (Match item in matches)
            {
                if (i < matches.Count - 1)
                {
                    Console.Write($"{item.Groups[2].Value}, ");
                }
                else
                {
                    Console.Write($"{item.Groups[2].Value}");
                }
                i++;
                sb.Append(item.Groups[2].Value);
            }
            Console.WriteLine();
            Console.WriteLine("Travel Points: " + sb.Length);
        }
    }
}
