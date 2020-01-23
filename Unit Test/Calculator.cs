using System;

namespace Calculator
{
    public class Operations
    {
        public int Add(int operand1,int operand2)
        {
            return operand1 + operand2;
        }
        public int Subtract(int operand1, int operand2)
        {
            return operand1 - operand2;
        }
        public int Multiply(int operand1, int operand2)
        {
            return operand1 * operand2;
        }
        public double Divide(double operand1, double operand2)
        {
            if (operand2 == 0)
                throw new DivideByZeroException();
            return operand1 / operand2;

        }
    }
}
