using System;
using System.Collections.Generic;

namespace Generics
{
    internal class ArithmeticOperations
    {
        public void Add<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.WriteLine(num1 + num2);
        }
        public void Sub<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.WriteLine(num1 - num2);
        }
    }

    internal class ArithmeticOperationsGenericClass<T>
    {
        public void Add(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.WriteLine(num1 + num2);
        }
        public void Sub(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.WriteLine(num1 - num2);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Invoking a generic method
            Compare<int>(10, 20);

            //Invoking a normal class members - Here we should specify the type with all the function calls.
            ArithmeticOperations obj1 = new ArithmeticOperations();
            obj1.Add<int>(10, 20);
            obj1.Sub<int>(10, 20);

            //Invoking a Generic class members - Here we no need to specify the type with each function call, instead
            //we will specify it with the class itself.
            ArithmeticOperationsGenericClass<int> obj2 = new ArithmeticOperationsGenericClass<int>();
            //The above statement means that all the methods inside the class are generic and this object can use only the
            //Integer type

            obj2.Add(10, 20);
            obj2.Sub(10, 20);

            //If we want to make all the methods generic inside a class we can make the class itself as a generic.

            Console.ReadKey();
            
        }

        static void Compare<T>(T a, T b)
        {
            if (a.Equals(b)) //Comparing like objects
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
