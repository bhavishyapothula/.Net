using System;
using System.Collections;
namespace Collectionll
{
    /// <summary>
    /// Node class containing data and next node
    /// </summary>
    public class Node
    {
       public int data;
       public Node next;
       public Node(int val)
        {
            data = val;
            next = null;
        }
    }


    public class Bhavi:IEnumerable
    {

        Node head = null;
        public int count = 0;
        public BhaviListEnum GetEnumerator()
        {
            return new BhaviListEnum(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }
        /// <summary>
        /// Adds element to list
        /// </summary>
        /// <param name="value">Value to be added</param>
        /// <returns>Index at which element is added</returns>
        public int Add(int value)
        {
            Node n = new Node(value);
            if (head == null)
                head = n;
            else
            {
                Node curr = head;
                while(curr.next!=null)
                {
                    curr = curr.next;
                }
                curr.next = n;
            }
            count++;
            Console.WriteLine("Element added");
            return count - 1;
        }
        /// <summary>
        /// Inserts at given position
        /// </summary>
        /// <param name="index">Index where element is to be added</param>
        /// <param name="value">Value of element to be added </param>
        public void Insert(int index,int value)
        {
            if(index==count)
            {
                Add(value);
                return;
            }
            Node n = new Node(value);
            Node cur = head;
            Node prev = null;
            if(index==0)
            {
                n.next = head;
                head = n;
            }
            else
            {
                for (int i = 0; i < index; i++)
                {
                    if (cur != null)
                    {
                        prev = cur;
                        cur = cur.next;
                    }
                }
                prev.next = n;
                n.next = cur;
            }
        }
        /// <summary>
        /// Removes element at particular index
        /// </summary>
        /// <param name="index">Index which is to be deleted</param>
        public void RemoveAt(int index)
        {
            Node cur = head,prev=null;
            if (index>=count)
            {
                Console.WriteLine("Index not found");
                return;
            }
            else if(index==0)
            {
                head = head.next;
                Console.WriteLine("Element deleted");
                return;
            }
            else
            {
                for(int i=0;i<index;i++)
                {
                    if (cur != null)
                    {
                        prev = cur;
                        cur = cur.next;
                    }
                }
                if (cur == null)
                {
                    Console.WriteLine("Element not found");
                    return;
                }
                if (cur != null)
                {
                    prev.next = cur.next;
                    Console.WriteLine("Element deleted");
                }
            }
        }
        /// <summary>
        /// Remove the first occurance of given value in list
        /// </summary>
        /// <param name="value">Value to be deleted</param>
        public void Remove(int value)
        {
           
            Node cur = head;
            if(head==null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            else if (value.Equals(head.data))
            {
                head = head.next;
                Console.WriteLine("Element deleted");
                return; 
            }

            Node prev = null;

            while (cur != null && value.Equals(cur.data))
            {

                prev = cur;
                cur = cur.next;
            }

            if (cur == null)
            {
                Console.WriteLine("Element not found");
                return;
            }
            if (cur != null)
            {
                prev.next = cur.next;
                Console.WriteLine("Element deleted");
            }
        }
 /// <summary>
 /// Displays elemrnts in list
 /// </summary>
        public void Display()
        {
            Node curr = head;
            while (curr!= null)
            {
                Console.WriteLine(curr.data);
                curr = curr.next;
            }
        }
        /// <summary>
        /// Checks if given value is in list or not
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if element is present else returns false</returns>
        public bool Contains(int value)
        {
            Node curr = head;
            while (curr != null)
            {
                if (value.Equals(curr.data))
                    return true;
                else
                curr = curr.next;
            }
            return false;
        }
        /// <summary>
        /// Find index of given element
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Index if element is presnt -1 if it is not present</returns>
        public int IndexOf(int value)
        {
            int index = -1;
            Node curr = head;
            while (curr != null)
            {
                index++;
                if (value.Equals(curr.data))
                    return index;
                else
                    curr = curr.next;
            }
            return -1;
        }
        /// <summary>
        /// Sort elements in list
        /// </summary>
        public void Sort()
        {
            Node temp1 = null, temp2 = null;
            int tempData;
            for(temp1=head;temp1.next!=null;temp1=temp1.next)
            {
                for (temp2 = temp1.next; temp2!= null; temp2 = temp2.next)
                {
                    if((temp1.data)>temp2.data)
                    {
                        tempData = temp1.data;
                        temp1.data = temp2.data;
                        temp2.data = tempData;
                    }
                }
            }
        }
        /// <summary>
        /// Gets element data at given index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Get(int index)
        {
            Node cur = head;
            for(int i=0;i<index;i++)
            {
                cur = cur.next;
            }
            return cur.data;
        }

    }
    public class BhaviListEnum : IEnumerator
    {
        public Bhavi _list;



        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        int position = -1;



        public BhaviListEnum(Bhavi list)
        {
            _list = list;
        }



        public bool MoveNext()
        {
            position++;
            return (position < _list.count);
        }



        public void Reset()
        {
            position = -1;
        }



        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }



        public Object Current
        {
            get
            {
                try
                {
                    return _list.Get(position);
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }

    }

}
