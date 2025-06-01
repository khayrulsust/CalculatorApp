﻿// Basic calculator class
using CalculatorApp;

internal class BasicCalculator : IBasicCalculator
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
