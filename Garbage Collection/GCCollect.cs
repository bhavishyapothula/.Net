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

            Garbage ob1= new Garbage();
            Console.WriteLine("Assigning to null");
            ob1= null;
            GC.Collect();//Calling Garbage Collector manually
            Console.ReadLine();

        }
    }
}
