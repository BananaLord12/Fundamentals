using System;

namespace _2._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            Article article = new Article(input[0], input[1], input[2]);

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (inputs[0])
                {
                    case "Edit:":
                        string content = "";
                        for (int x = 1; x <= inputs.Length - 1; x++)
                        {
                            if (x == inputs.Length - 1) { content += inputs[x]; continue; }
                            content += inputs[x] + " ";
                        }
                        article.Edit(content);
                        break;
                    case "ChangeAuthor:":
                        string author = "";
                        for (int y = 1; y <= inputs.Length - 1; y++)
                        {
                            if (y == inputs.Length - 1) {author += inputs[y]; continue; }
                            author += inputs[y] + " ";
                        }
                        article.ChangeAuthor(author);
                        break;
                    case "Rename:":
                        string title = "";
                        for (int z = 1; z <= inputs.Length - 1; z++)
                        {
                            if (z == inputs.Length - 1) { title += inputs[z]; continue; }
                            title += inputs[z] + " ";
                        }
                        article.Rename(title);
                        break;
                }
            }
            article.ToString();
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newName)
        {
            Title = newName;
        }
        public void ToString()
        {
            Console.WriteLine($"{Title} - {Content}: {Author}");
        }
    }
}