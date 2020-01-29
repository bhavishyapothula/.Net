using System;
using System.IO;
using System.Text;
namespace GarbageCollectionDispose
{
    /// <summary>
    /// This class implements IDisposable Interface
    /// </summary>
    public class Program:IDisposable
    {
        bool is_dispose_called = false;
        /// <summary>
        /// Dispose function is implemented here,if it is called by developer suppresses the finalize method
        /// </summary>
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
        /// <summary>
        /// The destructor is converted to finalize method in IL code
        /// </summary>
        ~Program()
        {
            Console.WriteLine("Inside finalize");
            Dispose(false);
        }
        public static void Main(string[] args)
        {
 
            Program p = new Program();
            p.Dispose();//This calls Dispose method
            Program obj = new Program();//This calls Destructor to release unmanaged resources
            using (Program q=new Program())//By using dispose method is automatically called
            {
                Console.WriteLine("Inside using block");
            }
            Console.ReadLine();

        }
    }
}
