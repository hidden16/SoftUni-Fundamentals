using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"@[#]+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@";
            var containsNumRegex = @"[0-9]+";
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            StringBuilder barcode = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                var matches = Regex.Match(word, regex);
                if (matches.Success)
                {
                    sb.Append(matches.Groups["barcode"].Value);
                    var numCheck = Regex.Matches(sb.ToString(), containsNumRegex);
                    if (numCheck.Count > 0)
                    {
                        foreach (Match item in numCheck)
                        {
                            barcode.Append(item);
                        }
                        Console.WriteLine($"Product group: {barcode}");
                        barcode.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    sb.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }


        }
    }
}
