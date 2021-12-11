using System;
using System.Collections.Generic;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().Split();
            GetStringSum(words[0], words[1]);
        }
        public static void GetStringSum(string stringOne, string stringTwo)
        {
            int sum = 0;
            int minLenght = Math.Min(stringOne.Length, stringTwo.Length);
            for (int i = 0; i < minLenght; i++)
            {
                sum += stringOne[i] * stringTwo[i];
            }
            string longestLenghtString = stringOne.Length < stringTwo.Length ? stringTwo : stringOne;
            for (int i = minLenght; i < longestLenghtString.Length; i++)
            {
                sum += longestLenghtString[i];
            }
            Console.WriteLine(sum);
        }
    }
}
