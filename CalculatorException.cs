using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {

            string non = operation ?? throw new ArgumentNullException(nameof(operation), "This is a null operator and Can not be used to perform the exception");
            if (operation == "/")
            { 

                try
                {
                    return Divide(number1, number2);
                }
                //return Divide(number1, number2);
                catch (DivideByZeroException ex)
                {
                    //throw new ArithmeticException("Hey it is the Divisio Error",ex);
                    throw ;

                }
            }
            else
            {
                //throw new ArgumentOutOfRangeException(nameof(operation), "The Mathematical Operator is not found");
                //Console.WriteLine("Unknown operation.");
                //return 0;
                throw new CalculationOperationNotSupportedException(operation);
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}

