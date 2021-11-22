using System;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine()); // N
            int distanceBetweenPokes = int.Parse(Console.ReadLine()); // M
            int exhaustionFactor = int.Parse(Console.ReadLine()); // Y

            int timesPoked = 0;
            double percentages = pokePower / 2;

            while (pokePower >= distanceBetweenPokes)
            {
                timesPoked++;
                pokePower -= distanceBetweenPokes;
                if (pokePower == percentages && exhaustionFactor != 0)
                {
                    pokePower /= exhaustionFactor;
                }

            }
            Console.WriteLine(pokePower);
            Console.WriteLine(timesPoked);

        }
    }
}
