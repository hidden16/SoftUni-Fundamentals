using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            int oddEvenCounter = 0;
            string resource = string.Empty;
            while (true)
            {
                oddEvenCounter++;
                if (oddEvenCounter % 2 != 0)
                {
                    resource = Console.ReadLine();
                    if (resource == "stop")
                    {
                        break;
                    }
                    if (!resources.ContainsKey(resource))
                    {
                        resources.Add(resource, 0);
                    }
                }
                else if (oddEvenCounter % 2 == 0)
                {
                    int quantity = int.Parse(Console.ReadLine());
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quantity;
                    }
                }
            }
            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
