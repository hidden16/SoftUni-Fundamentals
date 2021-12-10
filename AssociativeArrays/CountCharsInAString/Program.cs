using System;
using System.Collections.Generic;
using System.Linq;
namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            char[] words = Console.ReadLine().ToCharArray();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != ' ')
                {
                    if (counts.ContainsKey(words[i]))
                    {
                        counts[words[i]]++;
                    }
                    else
                    {
                        counts.Add(words[i], 1);
                    }
                }
            }
            foreach (var word in counts)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}
