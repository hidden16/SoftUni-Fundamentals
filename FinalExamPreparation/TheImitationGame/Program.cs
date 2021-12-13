using System;
using System.Text;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder(word);
            string commands = Console.ReadLine();
            while (commands != "Decode")
            {
                var tokens = commands.Split("|");
                if (tokens[0] == "Move")
                {
                    var numOfLetters = int.Parse(tokens[1]);
                    for (int i = 0; i < numOfLetters; i++)
                    {
                        sb.Append(sb[i]);
                    }
                    sb.Remove(0, numOfLetters);
                }
                else if (tokens[0] == "Insert")
                {
                    var index = int.Parse(tokens[1]);
                    var value = tokens[2];
                    sb.Insert(index, value);
                }
                else if (tokens[0] == "ChangeAll")
                {
                    var substring = tokens[1];
                    var replacement = tokens[2];
                    if (sb.ToString().Contains(substring) && substring != replacement)
                    {
                        sb.Replace(substring, replacement);
                    }
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"The decrypted message is: {sb}");
        }
    }
}
