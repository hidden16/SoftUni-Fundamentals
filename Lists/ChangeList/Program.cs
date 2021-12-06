using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                string[] tokens = input.Split(' ');

                if (tokens[0] == "Delete")
                {
                    numbers.RemoveAll(n => n == int.Parse(tokens[1]));
                }

                if (tokens[0] == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);

                    numbers.Insert(position, element);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
