using System;
using System.Collections.Generic;

namespace CompareDelegate
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

    }
    internal class Program
    {
        public static int CompareStudents<Student>(Student s1, Student s2)
        {
            dynamic stud1 = s1;
            dynamic stud2 = s2;
            return stud1.StudentName.CompareTo(stud2.StudentName);
        }
        static void Main(string[] args)
        {
            
            List<Student> students = new List<Student>()
            {
                new Student(){StudentId= 107, StudentAge = 25, StudentName ="Sreejith"},
                new Student(){StudentId= 102, StudentAge = 35, StudentName ="Arun"},
                new Student(){StudentId= 105, StudentAge = 27, StudentName ="Seban"},
                new Student(){StudentId= 110, StudentAge = 30, StudentName ="Amal"},
            };

            //Method - 1 creating an object of the Comparison delegate
            Comparison<Student> obj = new Comparison<Student>(CompareStudents);
            students.Sort(obj);

            //Method - 2 Directly providing the method which has the delegate's signature
            students.Sort(CompareStudents);

            //Method - 3 Anonymous function
            students.Sort(delegate (Student a, Student b)
            {
                return a.StudentName.CompareTo(b.StudentName);

            });

            //Method - 4 Lambda Expression
            students.Sort((Student a, Student b) => a.StudentName.CompareTo(b.StudentName));

            foreach (Student item in students)
            {
                Console.WriteLine($"Id of {item.StudentName} is {item.StudentId}, and age is {item.StudentAge}");
            }

            Console.ReadKey();
        }
    }
}
