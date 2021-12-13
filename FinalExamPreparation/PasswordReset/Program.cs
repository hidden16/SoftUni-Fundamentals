using System;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "Done")
                {
                    Console.WriteLine($"Your password is: {word}");
                    return;
                }
                var tokens = commands.Split(" ");
                if (tokens[0] == "TakeOdd")
                {
                    int i = 0;
                    foreach (var letter in word)
                    {
                        if (i % 2 == 1)
                        {
                            sb.Append(letter);
                        }
                        i++;
                    }
                    word = sb.ToString();
                    Console.WriteLine(sb);
                }
                else if (tokens[0] == "Cut")
                {
                    var index = int.Parse(tokens[1]);
                    var lenght = int.Parse(tokens[2]);
                    word = word.Remove(index, lenght);
                    Console.WriteLine(word);

                }
                else if (tokens[0] == "Substitute")
                {
                    var substring = tokens[1];
                    var substitute = tokens[2];
                    if (word.Contains(substring) && substring != substitute)
                    {
                        word = word.Replace(substring, substitute);
                        Console.WriteLine(word);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
            }
        }
    }
}
