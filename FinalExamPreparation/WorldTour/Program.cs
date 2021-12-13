using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DestinationMapper
{

    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            StringBuilder sb = new StringBuilder(word);

            string commands = Console.ReadLine();
            while (commands != "Travel")
            {
                var tokens = commands.Split(":");
                if (tokens[0] == "Add Stop")
                {
                    var index = int.Parse(tokens[1]);
                    var text = tokens[2];

                    if (index >= 0 && index < sb.Length)
                    {
                        sb.Insert(index, text);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine(sb);
                    }
                }
                else if (tokens[0] == "Remove Stop")
                {
                    var startIndex = int.Parse(tokens[1]);
                    var endIndex = int.Parse(tokens[2]);

                    if ((startIndex >= 0 && startIndex < sb.Length) && (endIndex >= 0 && endIndex < sb.Length) && endIndex >= startIndex)
                    {
                        sb.Remove(startIndex, (endIndex + 1) - startIndex);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine(sb);
                    }
                }
                else if (tokens[0] == "Switch")
                {
                    var oldString = tokens[1];
                    var newString = tokens[2];
                    if (sb.ToString().Contains(oldString) && oldString != newString)
                    {
                        sb.Replace(oldString, newString);
                        Console.WriteLine(sb);
                    }
                    else
                    {
                        Console.WriteLine(sb);
                    }
                }

                commands = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {sb}");
        }
    }
}
