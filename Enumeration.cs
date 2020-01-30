using System;
using System.Collections.Generic;
namespace Enumeration
{
    class Program
    {
       
        static void Main(String[] args)
        {
            //Creating a list of Integers
            List<int> Salaries = new List<int>();
            Salaries.Add(100000);
            Salaries.Add(250000);
            Salaries.Add(450000);
            Salaries.Add(580000);
            Salaries.Add(600000);
            Salaries.Add(840000);
            Salaries.Add(987000);
            IEnumerator<int> iEnumeratorOfInt = Salaries.GetEnumerator();
            Console.WriteLine("With Enumerator");
            EnumeratorWithoutTax(iEnumeratorOfInt);

            static void EnumeratorWithoutTax(IEnumerator<int> i)
            {
                Console.WriteLine("Without tax");
                while (i.MoveNext())
                {
                    Console.WriteLine(i.Current);

                    if (i.Current>=600000)
                    {
                        EnumeratorWithTax(i);
                        //Enumerator remembers the current state
                    }
                }
            }
           
            static void EnumeratorWithTax(IEnumerator<int> i)
            {
                Console.WriteLine("In tax");
                while (i.MoveNext())
                {
                    Console.WriteLine(i.Current);
                }
            }
            IEnumerable<int> iEnumerableOfint = (IEnumerable<int>)Salaries;
            Console.WriteLine("With Enumerable");
            EnumerableWithoutTax(iEnumerableOfint);

            static void EnumerableWithoutTax(IEnumerable<int> i)
            {
                Console.WriteLine("Without tax");
                foreach (int x in i)
                {
                    Console.WriteLine(x);
                    if (x>=600000)
                    {
                        EnumerableWithTax(i);
                        //Enumerable doesn't remenmber the current state
                    }
                }
            }

            static void EnumerableWithTax(IEnumerable<int> i)
            {
                Console.WriteLine("In tax");
                foreach (int x in i)
                {
                    Console.WriteLine(x);
                }
            }
        }
    }
}
