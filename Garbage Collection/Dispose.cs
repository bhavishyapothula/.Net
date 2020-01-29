using System;
namespace GarbageCollectionDispose
{
    /// <summary>
    /// This class implements IDisposable Interface
    /// </summary>
    public class Memorymgmt:IDisposable
    {
        bool isDisposeCalled = false;
        /// <summary>
        /// Dispose function is implemented here,if it is called by developer suppresses the final method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool disposeBoth)
        {
            if (!isDisposeCalled)
            {
                if (disposeBoth)
                {

                    Console.WriteLine("Managed code disposes here");
                }

                Console.WriteLine("Unmanaged resources are released here.");
                isDisposeCalled = true;
            }
        }
        /// <summary>
        /// The destructor is converted to finalize method in IL code
        /// </summary>
        ~Memorymgmt()
        {
            Console.WriteLine("Inside finalize");
            Dispose(false);
        }
        public static void Main(string[] args)
        {

            Memorymgmt ob1 = new Memorymgmt();
            ob1.Dispose();//This calls Dispose method
            Memorymgmt obj = new Memorymgmt();//This calls Destructor to release unmanaged resources
            using (Memorymgmt ob2 =new Memorymgmt())//By using dispose method is automatically called
            {
                Console.WriteLine("Inside using block");
            }
            Console.ReadLine();

        }
    }
}
