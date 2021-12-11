using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegExExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"[>]{2}(?<product>[A-z]+)[<]{2}(?<price>[0-9]+\.?[0-9]+)[!](?<quantity>\d+)";
            double totalMoney = 0;
            List<string> productNames = new List<string>();
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "Purchase")
                {
                    break;
                }
                var matches = Regex.Matches(word, regex);

                foreach (Match item in matches)
                {
                    string product = item.Groups["product"].Value;
                    double price = double.Parse(item.Groups["price"].Value);
                    int quantity = int.Parse(item.Groups["quantity"].Value);
                    productNames.Add(product);
                    totalMoney += price * quantity;
                }
            }
            Console.WriteLine("Bought furniture:");
            foreach (var item in productNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
