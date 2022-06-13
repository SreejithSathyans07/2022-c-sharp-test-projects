using System;

namespace AbstractClasses
{
    internal class Program : Student
    {
        static void Main(string[] args)
        {
            Program obj = new Program();

            Student sObj = obj; //This way is also possible

            sObj.SayHello();
            sObj.CalculateMark(75);
            Console.ReadKey();
        }

        public override void CalculateMark(int attendence)
        {
           string result = (attendence > 70) ? "Pass" : "Fail";
           Console.WriteLine(result);
        }
    }
}
