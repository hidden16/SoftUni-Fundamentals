using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beerKegsCount = int.Parse(Console.ReadLine());
            string model;
            double radius;
            int height;
            double volume = 0.0;

            double biggestKeg = double.MinValue;
            string biggestBeer = "";
            for (int i = 1; i <= beerKegsCount; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                height = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    biggestBeer = model;
                }
            }
            Console.WriteLine(biggestBeer);
        }
    }
}
