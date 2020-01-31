using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
namespace Objectmodel
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(13);
            list.Add(51);
            //Creating a readonly collection
            ReadOnlyCollection<int> readOnlyCollection = new ReadOnlyCollection<int>(list);
            // Loop over ReadOnlyCollection.
            foreach (int value in readOnlyCollection)
            {
                Console.WriteLine(value);
            }
            // Copy ReadOnlyCollection to an array.
            int[] array = new int[3];
            readOnlyCollection.CopyTo(array, 0);
            // Display array.
            Console.WriteLine("Array");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            int count = readOnlyCollection.Count;
            bool contains = readOnlyCollection.Contains(4);
            int index = readOnlyCollection.IndexOf(13);
            Console.WriteLine("Count:"+ count);
            Console.WriteLine("Contains 4:"+ contains);
            Console.WriteLine("Indx of 13:"+ index);
            Console.ReadLine();
        }
    }
}
