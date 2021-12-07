using System;
using System.Linq;

namespace Counter_Strike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int distance = 0;
            int winCounter = 0;
            while (input != "End of battle")
            {
                distance = int.Parse(input);
                if (energy >= distance)
                {
                    energy -= distance;
                    winCounter++;
                    if (winCounter % 3 == 0)
                    {
                        energy += winCounter;
                    }
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {winCounter} won battles and {energy} energy");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Won battles: {winCounter}. Energy left: {energy}");
        }
    }
}