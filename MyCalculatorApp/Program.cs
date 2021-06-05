using System;

namespace MyCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Calculator application!!");
            Console.WriteLine("Please press:");
            Console.WriteLine("1. '+' for addtion");
            Console.WriteLine("2. '-' for subtraction");
            Console.WriteLine("3. '*' for multiplication");
            Console.WriteLine("4. '/' for division");

            bool flag = true;
            double result = 0;

            
            while (flag)
            {
                var operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Calculator.GetValues(out Calculator.num1, out Calculator.num2);
                        result = Calculator.Addition(Calculator.num1, Calculator.num2);
                        flag = false;
                        break;
                    case "-":
                        Calculator.GetValues(out Calculator.num1, out Calculator.num2);
                        result = Calculator.Subtraction(Calculator.num1, Calculator.num2);
                        flag = false;
                        break;
                    case "*":
                        Calculator.GetValues(out Calculator.num1, out Calculator.num2);
                        result = Calculator.Multiply(Calculator.num1, Calculator.num2); 
                        flag = false;
                        break;
                    case "/":
                        Calculator.GetValues(out Calculator.num1, out Calculator.num2);
                        result = Calculator.Division(Calculator.num1, Calculator.num2);
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input!!\nPlease enter again.");
                        break;
                }
            }

            Console.WriteLine("The calculated result is: {0}", result);
        }
    }
}
