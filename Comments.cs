using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter basic salary");
            //Reads basic salary from console
            double bs = Convert.ToDouble(Console.ReadLine());
            CalculateSalary c = new CalculateSalary();
            Console.WriteLine("Net salary:"+c.CalculateNet(bs));
        }
    }
    /// <summary>
    /// This class contains methods to calculate net salary
    /// </summary>
    /// <remarks>This class contains methods to calculate da,hra,pf and net salary</remarks>
    class CalculateSalary
    {
        /// <summary>
        /// This method calculates DA for given basic salary 
        /// </summary>
        /// <param name="salary">This method takes double value as parameter</param>
        /// <returns>Returns double value</returns>
        double CalculateDA(double salary)
        {
            return salary * 0.3;
        }
        /// <summary>
        ///  This method calculates HRA for given basic salary 
        /// </summary>
        /// <param name="salary">This method takes double value as parameter</param>
        /// <returns>Returns double value</returns>
        double CalculateHRA(double salary)
        {
            return salary * 0.125;
        }
        /// <summary>
        ///  This method calculates PF for given basic salary
        /// </summary>
        /// <param name="salary">This method takes double value as parameter</param>
        /// <returns>Returns double value</returns>
        double CalculatePF(double salary)
        {
            return salary * 0.1;
        }
        /// <summary>
        ///  This method calculates Net for given basic salary
        /// </summary>
        /// <param name="salary">This method takes double value as parameter</param>
        /// <returns>Returns double value</returns>
        public double CalculateNet(double salary)
        {
            return salary + CalculateDA(salary) + CalculateHRA(salary) - CalculatePF(salary);

        }
    }
}
