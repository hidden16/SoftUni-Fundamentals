using System;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] test = new char[word.Length];
            for (int i = 0; i < word.Length; i++)
            {
                test = word.ToCharArray();
                if (i + 2 <= word.Length)
                {
                    if (word[i] == word[i + 1])
                    {
                        word = word.Remove(i, 1);
                        i = -1;
                    }
                }
            }
            Console.WriteLine(word);
        }
    }
}
