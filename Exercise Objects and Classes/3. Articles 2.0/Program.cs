namespace _3._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Articles article = new Articles();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                article.Article.Add(new Article
                {
                    Title = input[0],
                    Content = input[1],
                    Author = input[2]
                });
            }
            string data = Console.ReadLine();
            article.ToString();
        }
    }
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
    class Articles
    {
        public Articles()
        {
            Article = new List<Article>();
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public List<Article> Article { get; set; }

        public void ToString()
        {
            foreach(Article article in Article)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}