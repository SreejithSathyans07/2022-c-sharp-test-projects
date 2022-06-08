using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IComparable
{
    public class Student : IComparable<Student>
    {
        public int StudentId  { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }

        public int CompareTo(Student other)
        {
            if (this.StudentId > other.StudentId) return 1;
            else if(this.StudentId < other.StudentId) return -1;
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

            //Sorting the student ids using IComparable interface
            students.Sort();


            foreach (Student item in students)
            {
                Console.WriteLine($"Id of {item.StudentName} is {item.StudentId}, and age is {item.StudentAge}");
            }

            Console.ReadKey();
        }
    }
}
