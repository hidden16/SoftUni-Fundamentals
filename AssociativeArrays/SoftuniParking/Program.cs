using System;
using System.Collections.Generic;

namespace SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string username = input[1];
                if (input[0] == "register")
                {
                    string plate = input[2];
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {plate}");
                    }
                    else
                    {
                        parking.Add(username, plate);
                        Console.WriteLine($"{username} registered {plate} successfully");
                    }
                }
                else if (input[0] == "unregister")
                {
                    if (parking.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} unregistered successfully");
                        parking.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var user in parking)
            {
                Console.WriteLine(string.Join("\n", $"{user.Key} => {user.Value}"));
            }
        }
    }
}
