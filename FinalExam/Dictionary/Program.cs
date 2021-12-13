using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace FinalExamExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> library = new Dictionary<string, List<string>>();
            List<string> testWord = new List<string>();
            var input = Console.ReadLine();
            var wordsAndDefinitions = input.Split(" | ");
            for (int i = 0; i < wordsAndDefinitions.Length; i++)
            {
                var saveInString = wordsAndDefinitions[i];
                var savedSplit = saveInString.Split(": ");
                if (library.ContainsKey(savedSplit[0]))
                {
                    library[savedSplit[0]].Add(savedSplit[1]);
                }
                else
                {
                    library.Add(savedSplit[0], new List<string> { savedSplit[1] });

                }
            }
            var wordTest = Console.ReadLine().Split(" | ");
            for (int i = 0; i < wordTest.Length; i++)
            {
                testWord.Add(wordTest[i]);
            }
            var command = Console.ReadLine();
            if (command == "Test")
            {
                foreach (var word in library)
                {
                    for (int i = 0; i < testWord.Count; i++)
                    {
                        if (word.Key == testWord[i])
                        {
                            Console.WriteLine($"{word.Key}:");
                            foreach (var item in word.Value.OrderByDescending(x => x.Length))
                            {
                                Console.WriteLine($"-{item}");
                            }
                        }
                    }
                }
            }
            else if (command == "Hand Over")
            {
                foreach (var word in library.OrderBy(x => x.Key))
                {
                    Console.Write(word.Key + " ");
                }
            }

        }
    }
}
