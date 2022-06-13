using System;

namespace Interfaces
{
    internal class Student : INormalStudent, ISportsStudent
    {
        //Below method have same signature in both the interfaces and the child class object will always point to this method.
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
        public void DisplayResult(int attendance) 
        {
            Console.WriteLine($"Total marks {attendance * 70}");
        }
        public void DisplayResult(int attendance, float graceMark)
        {
            Console.WriteLine($"Total marks {attendance * 70 + graceMark}");
        }

        //Below 2 methods have same signature but providing different implementation for both the interfaces
        void INormalStudent.ShowDescription()
        {
            Console.WriteLine("Admission through Normal Process");
        }
        void ISportsStudent.ShowDescription()
        {
            Console.WriteLine("Admission through Sports Quota");
        }
        static void Main(string[] args)
        {
            Student student = new Student();
            student.SayHello();

            student.DisplayResult(35);

            student.DisplayResult(35, 4.5f);

            ISportsStudent sportsStudent = new Student();
            INormalStudent normalStudent = new Student();

            sportsStudent.ShowDescription();
            normalStudent.ShowDescription();

            Console.ReadKey();
        }
    }
}
