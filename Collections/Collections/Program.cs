/*
 - Arrays vs Collections
    - There are three main problems with arrays
        - It’s size can not be increased during the run time. even though Array.resize method is available, it internally destroys the array and recreates a new one.
        - Can not be inserted items to one particular position (except the last index)
        - Can not remove items from one particular position (except the last index)
    - Collections can resolve these problems.
    - Earlier version of .NET introduced Non-Generic collections
    - Non-Generic Collections include Stack, Queue, LinkedList, SortedList, ArrayList, HashTable etc.
    - In older languages like C or C++, there were no Stacks or Queues readily available. 
       There we had do define it first and then use it. in .NET collections are readily 
       available as classes under the namespace System.Collections.
 */


using System;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();

            arrList.Add(100);
            arrList.Add(200);
            arrList.Add(300);
            arrList.Add(400);
            arrList.Add(500);
            arrList.Add(500.05);
            arrList.Add(500.10);

            //Inserting an item to a position
            arrList.Insert(3, 350);
            DisplayCollection(arrList);

            //removing an item directly - This will remove only the first occurance of the item
            arrList.Remove(350);
            DisplayCollection(arrList);

            //removing an item by specifying the index
            arrList.RemoveAt(3);
            DisplayCollection(arrList);

            //removing items with in a range
            arrList.RemoveRange(4,2);
            DisplayCollection(arrList);

            Console.ReadKey();
        }

        public static void DisplayCollection(ArrayList arrayList)
        {
            Console.WriteLine();
            foreach (var num in arrayList)
            {
                Console.Write($"{num} ");
            }
        }
    }
}
