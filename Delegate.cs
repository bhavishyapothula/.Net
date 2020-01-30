using System;
using System.Collections.Generic;
namespace Delegate
{
    public class Employee
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public int experience { get; set; }
        public int age { get; set; }
        /// <summary>
        /// Retirement function by passing delegate as object
        /// </summary>
        /// <param name="emp"></param>
        /// <param name="delobj"></param>
        public static void Retirement(List<Employee> emp,MyRetireDel delobj)
        {
            foreach(Employee candidate in emp)
            {
                if(delobj(candidate))
                {
                    Console.WriteLine(candidate.name+ ": retired");
                }
            }
        }

    }
    //Declaring delegate
   public delegate bool MyRetireDel(Employee emp);
    class Program
    {
        
        
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { id = 102, name = "Bhavishya", age=20, experience=5};
            Employee emp2 = new Employee { id = 113, name = "Ram", age = 70, experience = 45 };
            Employee emp3 = new Employee {id = 030, name = "Sita", age = 59, experience = 36 };
            List<Employee> myEmp = new List<Employee>() { emp1, emp2, emp3 };
            //Instantiating delegate object
            MyRetireDel delObj = new MyRetireDel(CanRetire);
            Employee.Retirement(myEmp, delObj);
        }
        //Declaring method with same signature as delegate
        public static bool CanRetire(Employee emp)
        {
           /* if (emp.age >= 60)
                return true;
            else
                return false;
            */
             if (emp.experience >= 35)
                return true;
            else
                return false;
             
        }
    }
}
