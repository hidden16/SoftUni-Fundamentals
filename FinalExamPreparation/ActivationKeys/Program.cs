using System;
using System.Text;

namespace ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder(word);

            string commands = Console.ReadLine();
            while (commands != "Generate")
            {
                var tokens = commands.Split(">>>");
                if (tokens[0] == "Contains")
                {
                    var substring = tokens[1];
                    if (sb.ToString().Contains(substring))
                    {
                        Console.WriteLine($"{sb} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (tokens[0] == "Flip")
                {
                    if (tokens[1] == "Upper")
                    {
                        var startIndex = int.Parse(tokens[2]);
                        var endIndex = int.Parse(tokens[3]);
                        string substring = sb.ToString(startIndex, endIndex - startIndex);
                        string substrinToUpper = substring.ToUpper();
                        sb.Replace(substring, substrinToUpper);
                        Console.WriteLine(sb);
                    }
                    else if (tokens[1] == "Lower")
                    {
                        var startIndex = int.Parse(tokens[2]);
                        var endIndex = int.Parse(tokens[3]);
                        string substring = sb.ToString(startIndex, endIndex - startIndex);
                        string substringToLower = substring.ToLower();
                        sb.Replace(substring, substringToLower);
                        Console.WriteLine(sb);
                    }
                }
                else if (tokens[0] == "Slice")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);
                    sb.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(sb);
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {sb}");
        }
    }
}
