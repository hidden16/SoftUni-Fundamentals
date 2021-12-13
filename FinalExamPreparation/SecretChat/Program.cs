using System;
using System.Text;

namespace TextProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            StringBuilder sb = new StringBuilder(word);

            string commands = Console.ReadLine();
            while (commands != "Reveal")
            {
                var tokens = commands.Split(":|:");
                if (tokens[0] == "InsertSpace")
                {
                    var index = int.Parse(tokens[1]);
                    sb.Insert(index, " ");
                    Console.WriteLine(sb);
                }
                else if (tokens[0] == "Reverse")
                {
                    var substring = tokens[1];
                    var reversedSubstring = string.Empty;
                    if (sb.ToString().Contains(substring))
                    {
                        var indexSubstring = sb.ToString().IndexOf(substring);
                        var subSave = sb.ToString().Substring(indexSubstring, substring.Length);
                        for (int i = subSave.Length - 1; i >= 0; i--)
                        {
                            reversedSubstring += substring[i];
                        }
                        sb.Remove(indexSubstring, substring.Length);
                        sb.Append(reversedSubstring);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine($"error");
                    }
                }
                else if (tokens[0] == "ChangeAll")
                {
                    var substring = tokens[1];
                    var replacement = tokens[2];
                    if (sb.ToString().Contains(substring) && substring != replacement)
                    {
                        sb.Replace(substring, replacement);
                        Console.WriteLine(sb);
                    }
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {sb}");
        }
    }
}
