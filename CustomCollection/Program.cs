using System;
using Collectionll;
using System.Collections.Generic;
namespace CustomCollection
{
    class Program
    {
        static void Main(string[] args)
        {
                Bhavi myArryList = new Bhavi();
                //Add method
                myArryList.Add(1);
                myArryList.Add(6);
                myArryList.Add(3);
                myArryList.Add(8);
                myArryList.Add(5);
                Console.WriteLine("Count:"+myArryList.count);
                Console.WriteLine("List Elements");
                foreach (int item in myArryList)
                {
                    Console.WriteLine(item);
                }
                //Remove
                myArryList.Remove(1);
                Console.WriteLine("After Removing:");
                myArryList.Display();
                Console.WriteLine("Has 1:"+myArryList.Contains(1));
                Console.WriteLine("Has 2:"+myArryList.Contains(2));
                //Removal at index
                myArryList.RemoveAt(0);
                myArryList.RemoveAt(2);
                myArryList.RemoveAt(3);
                myArryList.RemoveAt(4);
                Console.WriteLine("After Removing:");
                myArryList.Display();
                //Insert at Index
                myArryList.Insert(0, 5);
                myArryList.Insert(2, 10);
                myArryList.Insert(4, 4);
                Console.WriteLine("After Inserting:");
                myArryList.Display();
                Console.WriteLine("Index of 5:"+myArryList.IndexOf(5));
                Console.WriteLine("Index of 10:" + myArryList.IndexOf(10));
                Console.WriteLine("Index of 4:" + myArryList.IndexOf(4));
                Console.WriteLine("Index of 2:" + myArryList.IndexOf(2));
                Console.WriteLine("Before Sorting");
                myArryList.Display();
                myArryList.Sort();
                Console.WriteLine("After Sorting");
                foreach(int item in myArryList)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
