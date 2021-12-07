﻿using System;

namespace GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            food *= 1000;
            hay *= 1000;
            cover *= 1000;
            weight *= 1000;
            for (int i = 1; i <= 30; i++)
            {
                food -= 300;
                if (i % 2 == 0)
                {
                    hay = hay - (food * 0.05);
                }
                if (i % 3 == 0)
                {
                    cover -= (weight / 3);
                }
            }
            if (food >= 0 && hay >= 0 && cover >= 0)
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food / 1000:f2}, Hay: {hay / 1000:f2}, Cover: {cover / 1000:f2}.");
            }
            if (food < 0 || hay < 0 || cover < 0)
            {
                Console.WriteLine("Merry must go to the pet store!");
            }
        }
    }
}