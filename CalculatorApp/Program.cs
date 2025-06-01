using System;

namespace CalculatorApp
{
    
    interface IBasicCalculator
    {
        double Add(double a, double b);
        double Subtract(double a, double b);
        double Multiply(double a, double b);
        double Divide(double a, double b);
    }

    
    interface IScientificCalculator
    {
        double SquareRoot(double x);
        double Power(double baseNumber, double exponent);
    }

    
    class BasicCalculator : IBasicCalculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero.");
                return double.NaN;
            }
            return a / b;
        }
    }

   
    class ScientificCalculator : BasicCalculator, IScientificCalculator
    {
        public double SquareRoot(double x)
        {
            if (x < 0)
            {
                Console.WriteLine("Error: Cannot calculate square root of a negative number.");
                return double.NaN;
            }
            return Math.Sqrt(x);
        }

        public double Power(double baseNumber, double exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ScientificCalculator calculator = new ScientificCalculator();
            Console.WriteLine("Live Test : ASP.Net Core 22/05/2025");

            Console.WriteLine("Basic Calculator Operations:");
            Console.WriteLine($"10 + 5 = {calculator.Add(10, 5)}");
            Console.WriteLine($"10 - 5 = {calculator.Subtract(10, 5)}");
            Console.WriteLine($"10 * 5 = {calculator.Multiply(10, 5)}");
            Console.WriteLine($"10 / 5 = {calculator.Divide(10, 5)}");

            Console.WriteLine("\nScientific Calculator Operations:");
            Console.WriteLine($"Square Root of 16 = {calculator.SquareRoot(16)}");
            Console.WriteLine($"2 raised to the power 3 = {calculator.Power(2, 3)}");

            Console.ReadLine(); 
        }
    }
}