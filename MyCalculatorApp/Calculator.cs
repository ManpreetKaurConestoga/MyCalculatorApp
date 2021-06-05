using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculatorApp
{
    public class Calculator
    {
        public static double num1 = 0;
        public static double num2 = 0;

        public static void GetValues(out double num1, out double num2)
        {
            num1 = 0;
            num2 = 0;
            try
            {
                Console.WriteLine("Enter the first number:");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second number:");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Format of input is not correct.\nPlease enter double type values");
            }

        }

        public static double Addition(double num1, double num2)
        {
            return Math.Round((num1 + num2), 2);
        }

        public static double Subtraction(double num1, double num2)
        {
            return Math.Round((num1 - num2), 2);
        }

        public static double Multiply(double num1, double num2)
        {
            return Math.Round((num1 * num2), 2);
        }

        public static double Division(double num1, double num2)
        {
            try
            {
                return Math.Round((num1 / num2), 2);
            }
            catch (DivideByZeroException)
            {
                return (0);
            }
        }
    }
}
