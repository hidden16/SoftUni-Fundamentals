using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] token = input.Split(" -> ");
                string companyName = token[0];
                string employeeId = token[1];
                if (company.ContainsKey(companyName))
                {
                    if (company[companyName].Contains(employeeId))
                    {
                    }
                    else
                    {
                        company[companyName].Add(employeeId);
                    }
                }
                else
                {
                    company.Add(companyName, new List<string>() { employeeId });
                }
            }
            foreach (var item in company.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}");
                for (int i = 0; i < item.Value.Count; i++)
                {
                    Console.WriteLine(string.Join("\n", $"-- {item.Value[i]}"));
                }
            }
        }
    }
}
