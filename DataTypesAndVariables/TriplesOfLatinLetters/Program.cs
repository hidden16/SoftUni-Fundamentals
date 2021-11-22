using System;
using System.Linq;

namespace TrainingDataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char a = 'a'; a < 'a' + number; a++)
            {
                for (char b = 'a'; b < 'a' + number; b++)
                {
                    for (char c = 'a'; c < 'a' + number; c++)
                    {
                        Console.WriteLine($"{a}{b}{c}");
                    }
                }
            }
        }
    }
}
