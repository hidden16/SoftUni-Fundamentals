using System;
using System.Collections.Generic;
using System.Linq;

namespace Pirates
{
    class Pirate
    {
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Pirate> pirateInfo = new Dictionary<string, Pirate>();
            string commands = Console.ReadLine();
            while (commands != "Sail")
            {
                var tokens = commands.Split("||");
                var city = tokens[0];
                var population = int.Parse(tokens[1]);
                var gold = int.Parse(tokens[2]);
                if (!pirateInfo.ContainsKey(city))
                {
                    pirateInfo.Add(city, new Pirate { Population = population, Gold = gold });
                }
                else
                {
                    pirateInfo[city].Population += population;
                    pirateInfo[city].Gold += gold;
                }
                commands = Console.ReadLine();
            }
            var cmds = Console.ReadLine();
            while (cmds != "End")
            {
                var tokens = cmds.Split("=>");
                if (tokens[0] == "Plunder")
                {
                    var town = tokens[1];
                    var people = int.Parse(tokens[2]);
                    var gold = int.Parse(tokens[3]);
                    if (pirateInfo.ContainsKey(town))
                    {
                        pirateInfo[town].Population -= people;
                        pirateInfo[town].Gold -= gold;
                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");
                        if (pirateInfo[town].Population <= 0 || pirateInfo[town].Gold <= 0)
                        {
                            pirateInfo.Remove(town);
                            Console.WriteLine($"{town} has been wiped off the map!");
                        }
                    }
                }
                else if (tokens[0] == "Prosper")
                {
                    var town = tokens[1];
                    var gold = int.Parse(tokens[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        if (pirateInfo.ContainsKey(town))
                        {
                            pirateInfo[town].Gold += gold;
                            Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {pirateInfo[town].Gold} gold.");
                        }
                    }
                }

                cmds = Console.ReadLine();
            }
            if (pirateInfo.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {pirateInfo.Count} wealthy settlements to go to:");
                foreach (var pirate in pirateInfo.OrderByDescending(p => p.Value.Gold).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{pirate.Key} -> Population: {pirate.Value.Population} citizens, Gold: {pirate.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                return;
            }
        }
    }
}
