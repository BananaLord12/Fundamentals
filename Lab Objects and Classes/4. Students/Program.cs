using System;

namespace _4._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] token = input.Split().ToArray();
            List<Student> students = new List<Student>();

            while (input != "end")
            {
                token = input.Split();
                if(Student.IsStudentExisting(students, token[0], token[1]))
                {
                    Student theStudent = Student.GetStudent(students, token[0], token[1]);
                    theStudent.firstName= token[0];
                    theStudent.lastName= token[1];
                    theStudent.age = int.Parse(token[2]);
                    theStudent.homeTown = token[3];
                }
                else
                {
                    Student student = new Student();

                    student.firstName = token[0];
                    student.lastName = token[1];
                    student.age = int.Parse(token[2]);
                    student.homeTown = token[3];

                    students.Add(student);
                }
                input = Console.ReadLine();
                
            }

            string targetCity = Console.ReadLine();

            List<Student> filtered = students.Where(x => x.homeTown == targetCity).ToList();
            foreach (Student student in filtered)
            {
                Console.WriteLine($"{student.firstName} {student.lastName} is {student.age} years old.");
            }
        }
    }
    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string homeTown { get; set; }

        public static bool IsStudentExisting(List<Student> students, string firstName, string lastName)
        {
            foreach (Student student in students)
            {
                if (student.firstName == firstName && student.lastName == lastName)
                {
                    return true;
                }
            }
            return false;
        }
        public static Student GetStudent(List<Student> students, string firstname, string lastname)
        {
            Student existingStudent = null;
            foreach (Student student in students)
            {
                if (student.firstName == firstname && student.lastName == lastname)
                {
                    existingStudent = student;
                }
            }

            return existingStudent;
        }
    }
}