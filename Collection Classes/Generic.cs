using System;
using System.Collections.Generic;
namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gneric Stack
            Console.WriteLine("Stack");
            Stack<char> mys = new Stack<char>();
            //Adding elements to stack
            mys.Push('A');
            mys.Push('B');
            mys.Push('C');
            mys.Push('D');

            Console.WriteLine("Current stack: ");
            foreach (char c in mys)
                Console.Write(c + " ");

            Console.WriteLine();
            mys.Push('V');
            //Removing top element from stack
            char ch = (char)mys.Pop();
            Console.WriteLine("Current stack: ");
            foreach (char c in mys)
                Console.Write(c + " ");
            Console.WriteLine("Peek:" + mys.Peek());
            Console.WriteLine("Dictionary");
            //  Creating a dictionaryusing Dictionary<TKey,TValue> class 
            Dictionary<int, string> My_dict = new Dictionary<int, string>();

            // Adding key/value pairs  
            My_dict.Add(928, "Bhavishya");
            My_dict.Add(929, "Prathima");
            My_dict.Add(931, "Bhargavi");
            My_dict.Add(111, "RRR");
            foreach (KeyValuePair<int, string> ele in My_dict)
            {
                Console.WriteLine(ele.Key + " " + ele.Value);
            }
            My_dict.Remove(111);
            Console.WriteLine("After Removal");
            foreach (KeyValuePair<int, string> ele in My_dict)
            {
                Console.WriteLine(ele.Key + " " + ele.Value);
            }
            Console.WriteLine("List");
            List<int> firstlist = new List<int>();
            firstlist.Add(1);
            firstlist.Add(2);
            firstlist.Add(3);
            firstlist.Add(4);

            // Printing the Capacity of firstlist 
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist 
            Console.WriteLine("Count Is: " + firstlist.Count);

            // Adding some more 
            // elements in firstlist 
            firstlist.Add(5);
            foreach (int item in firstlist)
                Console.WriteLine(item);
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);
            firstlist.Remove(5);
            foreach (int item in firstlist)
                Console.WriteLine(item);
        }
    }
}
