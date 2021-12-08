using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string editContent)
        {
            Content = editContent;
        }
        public void ChangeAuthor(string editAuthor)
        {
            Author = editAuthor;
        }
        public void Rename(string rename)
        {
            Title = rename;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Article commands = new Article();

            List<string> test = Console.ReadLine().Split(",").ToList();

            commands.Title = test[0];
            commands.Content = test[1];
            commands.Author = test[2];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(":");

                if (input[0] == "Edit")
                {
                    commands.Edit(input[1]);
                }
                else if (input[0] == "ChangeAuthor")
                {
                    commands.ChangeAuthor(input[1]);
                }
                else if (input[0] == "Rename")
                {
                    commands.Rename(input[1]);
                }
            }
            Console.WriteLine($"{commands.Title} -{commands.Content}:{commands.Author}");
        }
    }
}
