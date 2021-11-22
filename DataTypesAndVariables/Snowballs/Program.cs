using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int madeSnowballs = int.Parse(Console.ReadLine());
            BigInteger highestVal = int.MinValue;
            BigInteger sum = 0;
            string output = "";
            for (int i = 0; i < madeSnowballs; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                sum = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (sum >= highestVal)
                {
                    highestVal = sum;
                    string result = ($"{snowballSnow} : {snowballTime} = {highestVal} ({snowballQuality})");
                    output = result;
                }
            }
            Console.WriteLine(output);
        }
    }
}
