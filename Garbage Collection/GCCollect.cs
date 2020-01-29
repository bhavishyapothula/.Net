using System;

namespace GCCollection
{
    public class Garbage 
    {
        Garbage()
        {
            Console.WriteLine("object created");
        }
        /// <summary>
        /// Finalize method
        /// </summary>
        ~Garbage()
        {
            Console.WriteLine("object destructed");
        }
        public static void Main(string[] args)
        {

            Garbage p = new Garbage();
            Console.WriteLine("Assigning to null");
            p = null;
           GC.Collect();//Calling Garbage Collector manually
            Console.ReadLine();

        }
    }
}
