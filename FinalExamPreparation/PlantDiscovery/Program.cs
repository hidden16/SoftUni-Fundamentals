using System;
using System.Collections.Generic;
using System.Linq;

namespace DictionaryExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> plantInfo = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var commands = Console.ReadLine().Split("<->");
                var plant = commands[0];
                var rarity = int.Parse(commands[1]);
                if (!plantInfo.ContainsKey(plant))
                {
                    plantInfo.Add(plant, new List<double> { rarity });
                }
            }
            var cmds = Console.ReadLine();
            while (cmds != "Exhibition")
            {
                var tokens = cmds.Split(new string[] { ": ", " - " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens[0] == "Rate")
                {
                    var plant = tokens[1];
                    var rating = int.Parse(tokens[2]);
                    if (plantInfo.ContainsKey(plant))
                    {
                        plantInfo[plant].Add(rating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (tokens[0] == "Update")
                {
                    var plant = tokens[1];
                    var newRarity = int.Parse(tokens[2]);
                    if (plantInfo.ContainsKey(plant))
                    {
                        plantInfo[plant][0] = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (tokens[0] == "Reset")
                {
                    var plant = tokens[1];
                    if (plantInfo.ContainsKey(plant))
                    {
                        var raritySaver = plantInfo[plant][0];
                        plantInfo[plant].Clear();
                        plantInfo[plant].Add(raritySaver);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                cmds = Console.ReadLine();
            }
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();
            foreach (var item in plantInfo)
            {
                var raritySave = item.Value[0];
                plantInfo[item.Key].RemoveAt(0);
                var count = plantInfo[item.Key].Count;
                double sum = plantInfo[item.Key].Sum();
                if (count != 0)
                {
                    sum /= count;
                }
                output.Add(item.Key, new List<double> { raritySave, sum });
            }
            output = output.OrderByDescending(x => x.Value[0]).ThenByDescending(x => x.Value[1]).ToDictionary(x => x.Key, x => x.Value);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in output)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value[0]}; Rating: {item.Value[1]:f2}");
            }
        }
    }
}
