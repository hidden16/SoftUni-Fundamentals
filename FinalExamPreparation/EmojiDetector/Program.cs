using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            var regex = @"(:{2}|\*{2})(?<name>[A-Z][a-z]{2,})\1";
            var digitsRegex = @"(\d)";
            MatchCollection matchDigits = Regex.Matches(text, digitsRegex);
            MatchCollection matches = Regex.Matches(text, regex);
            int coolThreshold = 1;
            foreach (Match item in matchDigits)
            {
                coolThreshold *= int.Parse(item.Value);
            }
            List<string> emojis = new List<string>();
            var emojiCounter = 0;
            foreach (Match item in matches)
            {
                emojiCounter++;
                var name = item.Groups["name"].Value;
                int asciiSum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    char lettersMatches = name[i];
                    asciiSum += lettersMatches;
                }
                if (asciiSum > coolThreshold)
                {
                    emojis.Add(item.Value);
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojiCounter} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", emojis));
        }
    }

}
