using System;
using System.Linq;

namespace BlackFlag
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] input = Console.ReadLine().Split('|').ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                string[] commands = input[i].Split();
                switch (commands[0])
                {
                    case "potion":
                        int heal = int.Parse(commands[1]);
                        int pastHealth = health;
                        health += heal;
                        if (health > 100)
                        {
                            health = 100;
                        }
                        heal = health - pastHealth;
                        Console.WriteLine($"You healed for {heal} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        int coinsFound = int.Parse(commands[1]);
                        Console.WriteLine($"You found {coinsFound} bitcoins.");
                        bitcoins += coinsFound;
                        break;
                    default:
                        int attack = int.Parse(commands[1]);
                        health -= attack;
                        if (health <= 0)
                        {
                            Console.WriteLine($"You died! Killed by {commands[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            return;
                        }
                        else
                        {
                            Console.WriteLine($"You slayed {commands[0]}.");
                        }
                        break;
                }
            }
            Console.WriteLine($"You've made it!\n Bitcoins: {bitcoins}\n Health: {health}");
        }
    }
}
