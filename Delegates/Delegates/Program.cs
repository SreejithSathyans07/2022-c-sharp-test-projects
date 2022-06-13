using System;

namespace Delegates
{
    internal class Program
    {
        //Declaring a delegate
        public delegate void AddDel(int a, int b);
        public delegate string HelloDel(string name);
        public void Add(int a, int b)
        {
            Console.WriteLine("The sum is " + (a + b));
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            AddDel _addDel = new AddDel(p.Add);//Initialize a delegate

            HelloDel _helloDel = new HelloDel(SayHello);

            _addDel.Invoke(100, 200); //Invoke a delegate
            Console.WriteLine(_helloDel.Invoke("Sreejith"));

            Console.ReadKey();
        }
    }
}
