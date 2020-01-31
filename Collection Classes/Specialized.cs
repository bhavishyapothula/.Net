using System;
using System.Collections.Specialized;
using System.Collections;
namespace specialized
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ordered dictionary");
            OrderedDictionary myod = new OrderedDictionary();
            //Adding elements to ordered dictionary
            myod.Add("928", "Bhavishya");
            myod.Add("929", "Prathima");
            myod.Add("931", "Bhargavi");
            myod.Add("964", "xyz");
            //Printing by index
            Console.WriteLine("Printing using Index");
            for (int i = 0; i < myod.Count; i++)
                Console.WriteLine(myod[i]);
            myod.Remove("964");
            //Printing by keys
            Console.WriteLine("Printing using Keys");
            ICollection mykeys = myod.Keys;
            foreach (Object ky in mykeys)
            {
                Console.WriteLine(ky + " " + myod[ky]);
            }
            Console.WriteLine("List Dictionary");
            ListDictionary ld = new ListDictionary();
            //Adding elements
            ld.Add("928", "Bhavishya");
            ld.Add("929", "Prathima");
            ld.Add("931", "Bhargavi");
            ld.Add("964", "xyz");
            Console.WriteLine("Number of Elements in ld");
            Console.WriteLine(ld.Count);
            Console.WriteLine("Elements in ld");
            //Display
            foreach (String i in ld.Keys)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Hybrid Dictionary");
            HybridDictionary hd = new HybridDictionary();
            //Adding elements
            hd.Add("928", "Bhavishya");
            hd.Add("929", "Prathima");
            hd.Add("931", "Bhargavi");
            hd.Add("964", "xyz");
            //Count
            Console.WriteLine("Number of Elements in Hybrid Dictionary");
            Console.WriteLine(hd.Count);
            //Display
            Console.WriteLine("Elements in HybridDictionary");
            foreach (String i in hd.Keys)
            {
                Console.WriteLine(i);
            }
        }
    }
}
