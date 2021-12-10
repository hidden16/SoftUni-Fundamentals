using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                if (input[0] == "buy")
                {
                    break;
                }
                string product = input[0];
                double price = double.Parse(input[1]);
                double quantity = double.Parse(input[2]);
                if (orders.ContainsKey(product))
                {
                    orders[product][0] = price;
                    orders[product][1] += quantity;
                }
                else
                {
                    orders.Add(product, new List<double> { price, quantity });
                }
            }
            foreach (var product in orders)
            {
                Console.WriteLine(string.Join("\n", $"{product.Key} -> {product.Value[0] * product.Value[1]:f2}"));
            }
        }
    }
}
