namespace _5._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Projects project = new Projects();

            string input = "";

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] token = input
                    .Split("-")
                    .ToArray();

                if (project.TeamExists(token[1]))
                {
                    Console.WriteLine($"Team {token[1]} was already created!");   
                    continue;
                }
                else if (project.CheckCreatorsTeam(token[0])) 
                {
                    Console.WriteLine($"{token[0]} cannot create another team!");
                    continue;
                }
                project.Participants.Add(new ProjectParticipants
                {
                    Name = token[1],
                    CreatorName = token[0],
                    participants = new List<string>()
                });
                Console.WriteLine($"Team {token[1]} has been created by {token[0]}!");
            }

            while (true)
            {
                input = Console.ReadLine();
                if (input == "end of assignment") break;

                string[] token = input
                    .Split("->").ToArray();

                if (!project.TeamExists(token[1]))
                {
                    Console.WriteLine($"Team {token[1]} does not exist!");
                    continue;
                }
                else if (project.CheckUsersStatus(token[0]))
                {
                    Console.WriteLine($"Member {token[0]} cannot join team {token[1]}!");
                    continue;
                }
                project.AddParticipant(token[0], token[1]);

            }
            project.PrintTeams();
        }
    }

    class ProjectParticipants
    {
        public string Name { get; set; }
        public string CreatorName { get; set; }
        public List<string> participants { get; set; }
    }

    class Projects
    {
        public Projects()
        {
            Participants = new List<ProjectParticipants>();      
        }

        
        public List<ProjectParticipants> Participants { get; set; }

        public bool TeamExists(string name)
        {
            foreach (ProjectParticipants item in Participants)
            {
                if(item.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckCreatorsTeam(string name)
        {
            foreach (ProjectParticipants item in Participants)
            {
                if(item.CreatorName == name)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CheckUsersStatus(string name)
        {
            foreach(ProjectParticipants item in Participants)
            {
                if (item.participants.Contains(name) || item.CreatorName == name)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddParticipant(string user, string team)
        {
            foreach (ProjectParticipants item in Participants)
            {
                if(item.Name == team)
                {
                    item.participants.Add(user);
                    break;
                }
            }
        }

        public void PrintTeams()
        {
            foreach(ProjectParticipants item in Participants.OrderBy(x => x.Name).OrderByDescending(y => y.participants.Count+1))
            {
                if(item.participants.Count != 0)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine($"- {item.CreatorName}");
                    foreach(string name in item.participants.OrderBy(x => x))
                    {
                        Console.WriteLine($"-- {name}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach(ProjectParticipants item in Participants.OrderBy(x => x.Name))
            {
                if(item.participants.Count == 0)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }

}