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
                        Calculator.Num1 = Calculator.InputNum1();
                        Calculator.Num2 = Calculator.InputNum2();
                        result = Calculator.Addition(Calculator.Num1, Calculator.Num2);
                        flag = false;
                        break;
                    case "-":
                        Calculator.Num1 = Calculator.InputNum1();
                        Calculator.Num2 = Calculator.InputNum2();
                        result = Calculator.Subtraction(Calculator.Num1, Calculator.Num2);
                        flag = false;
                        break;
                    case "*":
                        Calculator.Num1 = Calculator.InputNum1();
                        Calculator.Num2 = Calculator.InputNum2();
                        result = Calculator.Multiply(Calculator.Num1, Calculator.Num2); 
                        flag = false;
                        break;
                    case "/":
                        Calculator.Num1 = Calculator.InputNum1();
                        Calculator.Num2 = Calculator.InputNum2();
                        result = Calculator.Division(Calculator.Num1, Calculator.Num2);
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
