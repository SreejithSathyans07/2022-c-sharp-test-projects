/*
- In array or array list we are storing the items as key-value pairs. 
  The key is predefined and it is the index. We can  not change the key.
- When it comes to Hashtabels, the keys are user defined. So accessing the values will be very easy. 
  If it was an array list we will have to remember the indexes of each values.
- While storing the hash table values, the keys will be hashed. 
  So hashtable can be seemed as a combination of key, value and a hash value. we can not control on how the hashing is done.
- Because of the hashing, it is faster to retrieve the data from the hashtable.
 */

using System;
using System.Collections;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //storing one employee detail using arraylist
            ArrayList empArrList = new ArrayList();
            empArrList.Add("E03");
            empArrList.Add("Scott");
            empArrList.Add(45);
            empArrList.Add("Sales");

            //Printing the age of the employee from the arraylist
            Console.WriteLine("Age of the employee from arraylist : " + empArrList[2]);

            //storing one employee detail using Hashtable
            Hashtable empHashTable = new Hashtable();
            empHashTable.Add("EmpId", "E03");
            empHashTable.Add("Name", "Scott");
            empHashTable.Add("Age", 45);
            empHashTable.Add("Dept", "Sales");

            //Printing the age of the employee from the hashtable
            Console.WriteLine("Age of the employee from hashtable : " + empHashTable["Age"]);

            //printing all items of a hashtable
            Console.WriteLine();
            foreach (object key in empHashTable.Keys)
            {
                Console.WriteLine(key +" : "+ empHashTable[key]);
            }

            Console.ReadKey();
        }
    }
}
