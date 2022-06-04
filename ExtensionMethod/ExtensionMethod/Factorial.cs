/*
Two changes that we have to incorporate to make one method inside a class a helper method is:
1. Make the class as static
2. Add this keyword in the parameter list 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal static class Factorial
    {
        public static void GetFactorial(this int num)
        {
            int result = 0;
            for (int i = num; i > 0; i--)
            {
                result += num * num - 1;
            }
            Console.WriteLine(result);
        }
    }
}
