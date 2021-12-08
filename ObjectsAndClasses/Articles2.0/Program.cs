using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Articles
    {

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} -{Content}:{Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Articles> articles = new List<Articles>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(",").ToArray();

                var article = new Articles(input[0], input[1], input[2]);

                articles.Add(article);
            }
            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case "title":
                    articles = articles.OrderBy(article => article.Title).ToList();
                    break;
                case "content":
                    articles = articles.OrderBy(article => article.Content).ToList();
                    break;
                case "author":
                    articles = articles.OrderBy(article => article.Author).ToList();
                    break;

                default:
                    break;
            }
            Console.WriteLine(string.Join("\n", articles));
        }
    }
}
