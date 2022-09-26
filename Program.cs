
using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Converting Temperature's");
            double temp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Value it is Read is " + temp);
            Console.WriteLine(Program.FahrenheitToCelsius(temp));
        }

        static double FahrenheitToCelsius(double temperatureFahrenheit)
        {
            double temperatureCelsius = Convert.ToDouble((temperatureFahrenheit - 32) / 1.8);
            return temperatureCelsius;
        }
    }
}
