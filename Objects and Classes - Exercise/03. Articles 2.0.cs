using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace articles1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(", ");
                string title = tokens[0];
                string content = tokens[1];
                string author = tokens[2];

                Article article = new Article(title, content, author);
                articles.Add(article);
            }

            string criteria = Console.ReadLine();

            if (criteria=="title")
            {
                articles=articles.OrderBy(a => a.Title).ToList();
            }
            else if (criteria=="content")
            {
                articles.Sort((cont1, cont2) => cont1.Content.CompareTo(cont2.Content));
            }
            else if (criteria=="author")
            {
               articles= articles.OrderBy(a => a.Author).ToList();
            }

            Console.WriteLine(string.Join(Environment.NewLine,articles));
        }
    }
       
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
               
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
