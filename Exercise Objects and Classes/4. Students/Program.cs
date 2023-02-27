using System;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Students students = new Students();

            for (int i = 0; i < n; i++)
            {
                string[] inputs = Console.ReadLine().Split().ToArray();

                students.students.Add(new Student
                {
                    firstName = inputs[0],
                    lastName = inputs[1],
                    grade = float.Parse(inputs[2])
                });
            }
            students.ToString();
        }
    }

    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public float grade { get; set; }
    }

    class Students
    {
        public Students()
        {
            students = new List<Student>();
        }
        public List<Student> students { get; set; }

        public void ToString()
        {
            students = students.OrderByDescending(x => x.grade).ToList();
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.firstName} {student.lastName}: {student.grade:F2}");
            }
        }
    }
}