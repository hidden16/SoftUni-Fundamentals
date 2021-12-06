using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists_Exercise___03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());

            List<string> namesThatGoing = new List<string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string input = Console.ReadLine();

                string[] tokens = input.Split(' ');

                if (tokens[2] == "going!")
                {
                    string nameToAdd = tokens[0];

                    if (namesThatGoing.Count == 0)
                    {
                        namesThatGoing.Add(nameToAdd);
                    }
                    else
                    {
                        bool isInTheList = false;

                        for (int j = 0; j < namesThatGoing.Count; j++)
                        {
                            string currentName = namesThatGoing[j];

                            if (currentName == nameToAdd)
                            {
                                Console.WriteLine($"{nameToAdd} is already in the list!");
                                isInTheList = true;
                                break;
                            }

                        }
                        if (isInTheList == false)
                        {
                            namesThatGoing.Add(nameToAdd);
                        }
                    }
                }
                else if (tokens[2] == "not")
                {
                    string nameToRemove = tokens[0];
                    bool isInTheList = false;

                    for (int j = 0; j < namesThatGoing.Count; j++)
                    {
                        string currentName = namesThatGoing[j];

                        if (currentName == nameToRemove)
                        {
                            namesThatGoing.Remove(nameToRemove);
                            isInTheList = true;
                            break;
                        }
                    }
                    if (isInTheList == false)
                    {
                        Console.WriteLine($"{nameToRemove} is not in the list!");
                    }
                }

            }

            for (int i = 0; i < namesThatGoing.Count; i++)
            {
                Console.WriteLine(namesThatGoing[i]);
            }
        }
    }
}