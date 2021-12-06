using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            List<int> secondDeck = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            while (firstDeck.Count != 0 && secondDeck.Count != 0)
            {
                int firstPlayersCard = firstDeck[0];
                int secondPlayersCard = secondDeck[0];
                if (firstPlayersCard > secondPlayersCard)
                {
                    secondDeck.RemoveAt(0);
                    firstDeck.RemoveAt(0);
                    firstDeck.Add(firstPlayersCard);
                    firstDeck.Add(secondPlayersCard);
                }
                else if (firstPlayersCard < secondPlayersCard)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                    secondDeck.Add(secondPlayersCard);
                    secondDeck.Add(firstPlayersCard);
                }
                else if (firstPlayersCard == secondPlayersCard)
                {
                    firstDeck.RemoveAt(0);
                    secondDeck.RemoveAt(0);
                }
            }

            if (firstDeck.Count > secondDeck.Count)
            {
                int sum = firstDeck.Sum();
                Console.WriteLine($"First player wins! Sum: {sum}");
            }
            else
            {
                int sum = secondDeck.Sum();
                Console.WriteLine($"Second player wins! Sum: {sum}");
            }
        }
    }
}