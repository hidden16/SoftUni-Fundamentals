using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder(word);
            var commands = Console.ReadLine();
            var startCheck = string.Empty;
            while (commands != "End")
            {
                var tokens = commands.Split();
                if (tokens[0] == "Translate")
                {
                    var charReplace = tokens[1];
                    var replacement = tokens[2];
                    if (sb.ToString().Contains(charReplace))
                    {
                        sb.Replace(charReplace, replacement);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine(sb);
                    }
                }
                else if (tokens[0] == "Includes")
                {
                    var substring = tokens[1];
                    if (sb.ToString().Contains(substring))
                    {
                        Console.WriteLine($"True");
                    }
                    else
                    {
                        Console.WriteLine($"False");
                    }
                }
                else if (tokens[0] == "Start")
                {
                    var substring = tokens[1];
                    var indexOfSubstring = sb.ToString().IndexOf(substring);
                    startCheck = sb.ToString().Substring(0, substring.Length);
                    if (substring == startCheck)
                    {
                        Console.WriteLine($"True");
                    }
                    else
                    {
                        Console.WriteLine($"False");
                    }
                }
                else if (tokens[0] == "Lowercase")
                {
                    var toLowerString = sb.ToString().ToLower();
                    sb.Clear();
                    sb.Append(toLowerString);
                    Console.WriteLine(sb);
                }
                else if (tokens[0] == "FindIndex")
                {
                    var givenChar = tokens[1];
                    var indexToPrint = sb.ToString().LastIndexOf(givenChar);
                    Console.WriteLine(indexToPrint);
                }
                else if (tokens[0] == "Remove")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var count = int.Parse(tokens[2]);
                    sb.Remove(startIndex, count);
                    Console.WriteLine(sb);
                }
                commands = Console.ReadLine();
            }
        }
    }
}
