using System;

namespace GCCollection
{
    public class Garbage 
    {
        Garbage()
        {
            Console.WriteLine("object created");
        }
        ~Garbage()
        {
            Console.WriteLine("object destructed");
        }
        public static void Main(string[] args)
        {

            Garbage obj = new Garbage();
            Console.WriteLine("Assigning to null");
            obj = null;
            GC.Collect();
            Console.ReadLine();

        }
    }
}
