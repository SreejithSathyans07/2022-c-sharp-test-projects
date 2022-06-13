using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses
{
    internal abstract class Student
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!!");
        }
        public abstract void CalculateMark(int attendence);

    }
}
