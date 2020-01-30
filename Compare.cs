using System;
using System.Collections.Generic;
namespace Comparator
{
    class Employee : IComparable<Employee>, IEquatable<Employee>
    {

            public int empid { get; set; }
            public string name { get; set; }
            public double salary { get; set; }
        /// <summary>
        /// CompareTo function written based on empid to sort Employee List
        /// </summary>
        /// <param name="other">Takes other Employee object as parameter</param>
        /// <returns></returns>
            public int CompareTo(Employee other)
            {
                if (this.empid < other.empid)
                {
                    return -1;
                }
                else if (this.empid > other.empid)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        /// <summary>
        ///  Equals function written based on empid to check Equality of Employee objects
        /// </summary>
        /// <param name="other">Takes other Employee object as parameter</param>
        /// <returns></returns>
        public bool Equals(Employee other)
            {
                if (other == null) return false;
                return (this.empid.Equals(other.empid));
            }
            static void Main(string[] args)
            {

                    Employee emp1 = new Employee { empid = 102, name = "Bhavishya", salary = 49000.98 };
                    Employee emp2 = new Employee { empid = 113, name = "Ram", salary = 410000.16 };
                    Employee emp3 = new Employee { empid = 030, name = "Sita", salary = 10000.89};
                    Employee emp4 = new Employee { empid = 102, name = "Bhavishya", salary = 49000.98 };
                    Console.WriteLine(emp1.Equals(emp4));
                    Console.WriteLine(emp1.Equals(emp2));
                    List<Employee> myEmp = new List<Employee>() { emp1, emp2, emp3 };
                    myEmp.Sort();
                    Console.WriteLine("sorted by empid");
                    foreach (Employee emp in myEmp)
                    {
                        Console.WriteLine(emp.empid + " " + emp.name + " " + emp.salary);

                    }
                    Console.WriteLine("sorted by name");
                    MyCompararer obj = new MyCompararer();
                    myEmp.Sort(obj);
                    foreach (Employee emp in myEmp)
                    {
                        Console.WriteLine(emp.empid + " " + emp.name + " " + emp.salary);

                    }
                    Console.ReadKey();

            }
        /// <summary>
        /// MyComparer class implementing IComparer
        /// </summary>
            class MyCompararer : IComparer<Employee>
            {
            /// <summary>
            /// Compare function written based on name to sort Employee List
            /// </summary>
            /// <param name="emp1"></param>
            /// <param name="emp2"></param>
            /// <returns></returns>
            public int Compare(Employee emp1, Employee emp2)
                {
                    return (emp1.name).CompareTo(emp2.name);
                }

            }
        }
}
