namespace _5._Courses
{
    internal class Program
    {
        public static Dictionary<string, List<string>> Courses = new Dictionary<string, List<string>>();
        public static Dictionary<string, double> student = new Dictionary<string, double>();
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while(input != "end")
            {
                string[] token = input.Split(" : ").ToArray();

                if (Courses.ContainsKey(token[0]))
                {
                    Courses[token[0]].Add(token[1]);
                }
                else
                {
                    Courses.Add(token[0], new List<string>());
                    Courses[token[0]].Add(token[1]);
                }
                input = Console.ReadLine();
            }
            
            foreach(var course in Courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                for (int i = 0; i < course.Value.Count; i++)
                {
                    Console.WriteLine($"-- {course.Value[i]}");
                }
            }
        }
    }
}