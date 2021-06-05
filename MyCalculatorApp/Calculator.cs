using System;
using System.Collections.Generic;
using System.Text;

namespace MyCalculatorApp
{
    public class Calculator
    {
        private static double num1 = 0;
        private static double num2 = 0;

        public static double Num1   // property
        {
            get { return num1; }   // get method
            set { num1 = value; }  // set method
        }

        public static double Num2   // property
        {
            get { return num2; }   // get method
            set { num2 = value; }  // set method
        }

        public static double InputNum1()
        {
            try
            {
                Console.WriteLine("Enter the first number:");
                Num1 = Convert.ToDouble(Console.ReadLine());
                return Num1;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Format of input is not correct.\nPlease enter double type value");
                return 0;
            }

        }

        public static double InputNum2()
        {
            try
            {
                Console.WriteLine("Enter the second number:");
                Num2 = Convert.ToDouble(Console.ReadLine());
                return Num2;
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Format of input is not correct.\nPlease enter double type value");
                return 0;
            }

        }

        public static double Addition(double Num1, double Num2)
        {
            try
            {
                return Math.Round((Num1 + Num2), 2);
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return 0;
            }
        }

        public static double Subtraction(double Num1, double Num2)
        {
            try
            {
                return Math.Round((Num1 - Num2), 2);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return 0;
            }

        }

        public static double Multiply(double Num1, double Num2)
        {
            try
            {
                return Math.Round((Num1 * Num2), 2);
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                return 0;
            }
        }

        public static double Division(double Num1, double Num2)
        {
            try
            {
                return Math.Round((Num1 / Num2), 2);
            }
            catch (DivideByZeroException)
            {
                return (0);
            }
        }
    }
}
