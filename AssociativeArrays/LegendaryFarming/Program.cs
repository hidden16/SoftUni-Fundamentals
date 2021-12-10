using System;
using System.Collections.Generic;
using System.Linq;
namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendary = new Dictionary<string, int>();
            legendary.Add("shards", 0); //shards
            legendary.Add("fragments", 0); // fragments
            legendary.Add("motes", 0); // motes
            Dictionary<string, int> junk = new Dictionary<string, int>();
            int quantity = 0;
            string item = string.Empty;
            while (legendary["shards"] < 250 && legendary["fragments"] < 250 && legendary["motes"] < 250)
            {
                string input = Console.ReadLine().ToLower();
                string[] tokens = input.Split();
                for (int i = 0; i < tokens.Length; i += 2)
                {
                    quantity = int.Parse(tokens[i]);
                    item = tokens[i + 1];
                    switch (item)
                    {
                        case "shards":
                        case "fragments":
                        case "motes":
                            legendary[item] += quantity;
                            break;
                        default:
                            if (!junk.ContainsKey(item))
                            {
                                junk.Add(item, 0);
                            }
                            junk[item] += quantity;
                            break;
                    }
                    if (legendary["shards"] >= 250 || legendary["fragments"] >= 250 || legendary["motes"] >= 250)
                    {
                        break;
                    }
                }
            }
            string legendaryItem = string.Empty;
            if (legendary["shards"] >= 250)
            {
                legendaryItem = "Shadowmourne";
                legendary["shards"] -= 250;
            }
            else if (legendary["fragments"] >= 250)
            {
                legendaryItem = "Valanyr";
                legendary["fragments"] -= 250;
            }
            else
            {
                legendaryItem = "Dragonwrath";
                legendary["motes"] -= 250;
            }
            Console.WriteLine($"{legendaryItem} obtained!");
            foreach (var material in legendary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList())
            {
                Console.WriteLine(string.Join("\n", $"{material.Key}: {material.Value}"));
            }
            foreach (var trash in junk.OrderBy(x => x.Key).ToList())
            {
                Console.WriteLine(string.Join("\n", $"{trash.Key}: {trash.Value}"));
            }
        }
    }
}
