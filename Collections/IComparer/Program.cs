using System;
using System.Collections.Generic;

namespace IComparer
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

    }
    public class CompareStudents : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.StudentAge > y.StudentAge) return 1;
            else if (x.StudentAge < y.StudentAge) return -1;
            else return 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){StudentId= 107, StudentAge = 25, StudentName ="Sreejith"},
                new Student(){StudentId= 102, StudentAge = 35, StudentName ="Arun"},
                new Student(){StudentId= 105, StudentAge = 27, StudentName ="Seban"},
            };


            //If we do not have the permission to modify the class and yet need to sort based on some fields of Students, 
            //Then we can use the IComparer interface
            CompareStudents obj = new CompareStudents();
            students.Sort(obj);

            foreach (Student item in students)
            {
                Console.WriteLine($"Id of {item.StudentName} is {item.StudentId}, and age is {item.StudentAge}");
            }

            Console.ReadKey();
        }
    }
}
