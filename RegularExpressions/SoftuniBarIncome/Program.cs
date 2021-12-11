using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SofutniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"%(?<name>[A-Z][a-z]+)%[^%$|.]*<(?<product>\w+)>[^%$|.]*\|(?<quantity>\d+)\|[^%$|.]*?(?<price>\d+|\d+\.\d+)\$");
            double totalIncome = 0;
            StringBuilder sb = new StringBuilder();
            while (true)
            {
                string word = Console.ReadLine();
                if (word == "end of shift")
                {
                    break;
                }
                Match matches = regex.Match(word);
                if (matches.Success)
                {
                    var name = matches.Groups["name"].Value;
                    var product = matches.Groups["product"].Value;
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    var price = double.Parse(matches.Groups["price"].Value);
                    sb.AppendLine($"{name}: {product} - {price * quantity:f2}");
                    totalIncome += quantity * price;
                }
            }
            sb.AppendLine($"Total income: {totalIncome:f2}");
            Console.WriteLine(sb);
        }
    }
}
