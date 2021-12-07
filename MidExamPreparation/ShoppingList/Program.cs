using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productList = Console.ReadLine().Split("!").ToList();
            string input = Console.ReadLine();
            while (input != "Go Shopping!")
            {
                string[] token = input.Split();

                if (token[0] == "Urgent")
                {
                    if (productList.Contains(token[1]))
                    {

                    }
                    else
                    {
                        productList.Insert(0, token[1]);
                    }
                }
                if (token[0] == "Unnecessary")
                {
                    if (productList.Contains(token[1]))
                    {
                        productList.Remove(token[1]);
                    }
                }
                if (token[0] == "Correct")
                {
                    if (productList.Contains(token[1]))
                    {
                        for (int i = 0; i < productList.Count; i++)
                        {
                            if (productList[i] == token[1])
                            {
                                productList.Insert(i, token[2]);
                                productList.Remove(token[1]);
                            }
                        }
                    }
                }
                if (token[0] == "Rearrange")
                {
                    if (productList.Contains(token[1]))
                    {
                        productList.Remove(token[1]);
                        productList.Add(token[1]);
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", productList));
        }
    }
}
