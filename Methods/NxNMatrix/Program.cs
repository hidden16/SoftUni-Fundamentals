﻿using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = n; k <= n; k++)
                    {
                        Console.Write(k + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
