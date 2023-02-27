namespace _3._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split("_").ToArray();
                Song song = new Song();
                song.TypeList = input[0];
                song.Name= input[1];
                song.TIme= input[2];

                songs.Add(song);
            }

            string type = Console.ReadLine();

            if(type == "all")
            {
                foreach(Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredsongs = songs.Where(x => x.TypeList == type).ToList();
                foreach (Song song in filteredsongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }


        class Song
        {
            public string TypeList { get; set; }
            public string Name { get; set; }
            public string TIme { get; set; }
        }
    }
}