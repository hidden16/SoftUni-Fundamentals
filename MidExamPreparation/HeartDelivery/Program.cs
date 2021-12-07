using System;
using System.Collections.Generic;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighborhood = Console.ReadLine().Split("@").Select(int.Parse).ToList();

            string input = Console.ReadLine();
            int num = 0;
            int failCounter = 0;
            while (input != "Love!")
            {
                string[] token = input.Split();
                num += int.Parse(token[1]);
                if (token[0] == "Jump")
                {
                    if (num > neighborhood.Count - 1)
                    {
                        num = 0;
                    }
                    for (int i = num; i <= num; i++)
                    {
                        if (neighborhood[i] == 0)
                        {
                            Console.WriteLine($"Place {i} already had Valentine's day.");
                            break;
                        }
                        neighborhood[i] -= 2;
                        if (neighborhood[i] == 0)
                        {
                            Console.WriteLine($"Place {i} has Valentine's day.");
                        }
                    }
                }
                input = Console.ReadLine();
            }
            for (int i = 0; i < neighborhood.Count; i++)
            {
                if (neighborhood[i] > 0)
                {
                    failCounter++;
                }
            }
            Console.WriteLine($"Cupid's last position was {num}.");
            if (neighborhood.All(w => w == 0))
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failCounter} places.");
            }
        }
    }
}