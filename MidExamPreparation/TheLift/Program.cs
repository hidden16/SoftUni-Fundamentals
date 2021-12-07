using System;
using System.Collections.Generic;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int queue = int.Parse(Console.ReadLine());
            List<int> stateOfLift = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < stateOfLift.Count; i++)
            {
                while (stateOfLift[i] < 4)
                {
                    stateOfLift[i]++;
                    queue--;
                    if (queue == 0)
                    {
                        break;
                    }
                }
                if (queue == 0)
                {
                    break;
                }
            }
            if (stateOfLift.Any(w => w < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", stateOfLift));
            }
            else if (queue > 0 && stateOfLift.Any(w => w >= 4))
            {
                Console.WriteLine($"There isn't enough space! {queue} people in a queue!");
                Console.WriteLine(string.Join(" ", stateOfLift));
            }
            else if (queue == 0 && stateOfLift.Any(w => w == 4))
            {
                Console.WriteLine(string.Join(" ", stateOfLift));
            }
        }
    }
}
