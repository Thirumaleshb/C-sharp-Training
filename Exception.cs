using System;
using static System.Console;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();
            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine("Hey it is showing the arithmetic expression error"+ex);
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("the Paramter you have entered is null " + ex.Message);
            }
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("Enter the Correct operator" + ex.Message);
            //}
            catch (CalculationOperationNotSupportedException ex)
            {
                Console.WriteLine("We are invoking Custom methods" + ex);
                Console.WriteLine(ex.Message);
            }
            catch( Exception ex)
            {
                Console.WriteLine("Something is Wrong " + ex);
            }


            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void DisplayResult(int result) => WriteLine($"Result is: {result}");
    }
}


// FROM C# 9 "Top-level statements":

//using ConsoleCalculator;
//using static System.Console;


//WriteLine("Enter first number");
//int number1 = int.Parse(ReadLine());

//WriteLine("Enter second number");
//int number2 = int.Parse(ReadLine());

//WriteLine("Enter operation");
//string operation = ReadLine().ToUpperInvariant();


//var calculator = new Calculator();
//int result = calculator.Calculate(number1, number2, operation);
//DisplayResult(result);


//WriteLine("\nPress enter to exit.");
//ReadLine();


//void DisplayResult(int result)
//{
//    WriteLine($"Result is: {result}");
//}


