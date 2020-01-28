using System;
using System.IO;
using System.Text;
namespace GarbageCollectionDispose
{
    public class Program:IDisposable
    {
        bool is_dispose_called = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool dispose_both)
        {
            if (!is_dispose_called)
            {
                if (dispose_both)
                {

                    Console.WriteLine("Managed code disposes here");
                }

                Console.WriteLine("Unmanaged resources are released here.");
                is_dispose_called = true;
            }
        }
        ~Program()
        {
            Console.WriteLine("Inside finalize");
            Dispose(false);
        }
        public static void Main(string[] args)
        {
 
            Program p = new Program();
            p.Dispose();
            Program obj = new Program();
            using (Program q=new Program())
            {
                Console.WriteLine("Inside using block");
            }
            Console.ReadLine();

        }
    }
}
