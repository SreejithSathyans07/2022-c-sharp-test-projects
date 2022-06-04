using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial.GetFactorial(5); // Normal function call - This will also work
            int number = 7;
            number.GetFactorial(); // extension method. Internall it will be converted in to 'Factorial.GetFactorial(5)'
            Console.ReadKey();
        }
    }
}
