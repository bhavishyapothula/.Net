using System;
using System.Collections;
namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List");
            ArrayList mylist = new ArrayList();
            //Adding elements
            mylist.Add(1);
            mylist.Add(2);
            Console.WriteLine("Capacity:" + mylist.Capacity);
            Console.WriteLine("Count:" + mylist.Count);
            Console.WriteLine("Is fixed size:" + mylist.IsFixedSize);
            Console.WriteLine("Item[1]:" + mylist[1]);
            ArrayList newlist = new ArrayList();
            newlist.Add(3);
            newlist.Add(4);
            mylist.AddRange(newlist);
            foreach (Object i in mylist)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(mylist.BinarySearch(1));
            //Removing elements
            mylist.Remove(3);
            mylist.Reverse();
            foreach (Object i in mylist)
            {
                Console.WriteLine(i);
            }
            mylist.RemoveRange(1, 2);
            foreach (int i in mylist)
            {
                Console.WriteLine(i);
            }
            int[] myarr = (int[])mylist.ToArray(typeof(int));
            for (int i = 0; i < myarr.Length; i++)
            {
                Console.WriteLine(myarr[i]);
            }
            Console.WriteLine("Stack");
            Stack mys = new Stack();
            //Pushing elements to stack
            mys.Push('A');
            mys.Push('B');
            mys.Push('C');
            mys.Push('D');

            Console.WriteLine("Current Stack: ");
            foreach (Object obj in mys)
                Console.Write(obj + " ");

            Console.WriteLine();
            mys.Push('V');
            //Poping the top element from stack
            Object ch = (Object)mys.Pop();
            Console.WriteLine("Current Stack: ");
            foreach (Object obj in mys)
                Console.Write(obj + " ");
            //Retrieving top element from stack
            Console.WriteLine("Peek:" + mys.Peek());
            Console.WriteLine("Queue");
            Queue myq = new Queue();
            //Adding elements to queue
            myq.Enqueue('A');
            myq.Enqueue('B');
            myq.Enqueue('C');
            myq.Enqueue('D');

            Console.WriteLine("Current queue: ");
            foreach (Object obj in myq)
                Console.Write(obj + " ");

            Console.WriteLine();
            myq.Enqueue('V');
            //Removing element from queue
            ch = (Object)myq.Dequeue();
            Console.WriteLine("Current queue: ");
            foreach (Object obj in myq)
                Console.Write(obj + " ");
            Console.WriteLine("Peek:" + myq.Peek());
            Console.WriteLine("Hash Table");
            Hashtable ht = new Hashtable();
            //Adding elements to hash table 
            ht.Add("001", "Ram");
            ht.Add("002", "Sita");
            ht.Add("003", "Lakshman");
            ht.Add("004", "Hanuman");
            //Retrieving keys
            ICollection mykeys = ht.Keys;
            foreach (Object ky in mykeys)
            {
                Console.WriteLine(ky + " " + ht[ky]);
            }
            //Count
            Console.WriteLine(ht.Count);
            if (ht.ContainsValue("Bhavishya"))
            {
                Console.WriteLine("This name is already in the list");
            }
            else
            {
                ht.Add("005", "Bhavishya");
            }
            mykeys = ht.Keys;
            foreach (Object ky in mykeys)
            {
                Console.WriteLine(ky + " " + ht[ky]);
            }
        }
    }
}
