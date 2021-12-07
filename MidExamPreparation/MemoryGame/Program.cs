using System;
using System.Collections.Generic;
using System.Linq;


namespace MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split().ToList();


            string input = Console.ReadLine();

            int numberOfMoves = 0;
            while (input != "end")
            {
                string[] token = input.Split();
                numberOfMoves++;
                int indexOne = int.Parse(token[0]);
                int indexTwo = int.Parse(token[1]);
                if (indexOne == indexTwo)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                }
                else if (indexOne > numbers.Count - 1)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                }
                else if (indexTwo > numbers.Count - 1)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                }
                else if (indexOne < 0)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                }
                else if (indexTwo < 0)
                {
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                    numbers.Insert((numbers.Count) / 2, '-' + numberOfMoves.ToString() + 'a');
                }
                else if (numbers[indexOne] == numbers[indexTwo])
                {
                    if (numbers[indexOne] == numbers[indexTwo])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {numbers[indexOne]}!");
                        if (indexOne > indexTwo)
                        {
                            numbers.RemoveAt(indexOne);
                            numbers.RemoveAt(indexTwo);
                        }
                        else
                        {
                            numbers.RemoveAt(indexTwo);
                            numbers.RemoveAt(indexOne);
                        }
                    }
                }
                else if (!(numbers[indexOne] == numbers[indexTwo]))
                {
                    Console.WriteLine("Try again!");
                }
                if (numbers.Count == 0)
                {
                    Console.WriteLine($"You have won in {numberOfMoves} turns!");
                    return;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
