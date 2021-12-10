using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            string forceSide = string.Empty;
            string forceUser = string.Empty;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Lumpawaroo")
                {
                    break;
                }
                string[] delimeterOne = input.Split(" | ");
                string[] delimeterTwo = input.Split(" -> ");
                if (input.Contains(" | "))
                {
                    forceSide = delimeterOne[0];
                    forceUser = delimeterOne[1];
                    if (users.ContainsKey(forceSide))
                    {
                        if (!users[forceSide].Contains(forceUser))
                        {
                            users[forceSide].Add(forceUser);
                        }
                    }
                    else
                    {
                        users.Add(forceSide, new List<string>() { forceUser });
                    }
                }
                else
                {
                    forceSide = delimeterTwo[1];
                    forceUser = delimeterTwo[0];
                    if (!users.Values.Any(x => x.Contains(forceUser)))
                    {
                        if (!users.ContainsKey(forceSide))
                        {
                            users.Add(forceSide, new List<string>());
                        }
                        users[forceSide].Add(forceUser);
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                    else
                    {
                        foreach (var item in users.Where(user => user.Value.Contains(forceUser)))
                        {
                            item.Value.Remove(forceUser);
                        }
                        if (users.ContainsKey(forceSide))
                        {
                            users[forceSide].Add(forceUser);
                        }
                        else
                        {
                            users.Add(forceSide, new List<string>() { forceUser });
                        }
                        Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                    }
                }
            }
            foreach (var user in users.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value))
            {
                user.Value.Sort();
                if (user.Value.Count > 0)
                {

                    Console.WriteLine($"Side: {user.Key}, Members: {user.Value.Count}");
                    for (int i = 0; i < user.Value.Count; i++)
                    {

                        Console.WriteLine(string.Join("\n", $"! {user.Value[i]}"));
                    }
                }
            }
        }
    }
}
