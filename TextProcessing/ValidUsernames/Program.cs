using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TextProcessingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ");
            Regex regex1 = new Regex(@"^[a-zA-Z0-9_-]+$");
            foreach (var word in words)
            {
                if (regex1.IsMatch(word) && word.Length >= 3 && word.Length <= 16)
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
