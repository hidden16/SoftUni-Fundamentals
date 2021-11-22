using System;

namespace SpiceMustFLow
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int total = 0;
            int daysMined = 0;


            while (startingYield >= 100)
            {

                daysMined++;
                total += startingYield - 26;
                startingYield -= 10;

                if (startingYield < 100)
                {

                    total -= 26;
                }
            }
            Console.WriteLine(daysMined);
            Console.WriteLine(total);

        }
    }
}
