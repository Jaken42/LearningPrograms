using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my basic Calculator.\nWhat is your first number?");
            double num1 = input();
            Console.WriteLine("What is your second number?");
            double num2 = input();
            Console.WriteLine("What operator do you want?");
            string op = Console.ReadLine();
            if (op == "+") 
            {
                output(add(num1, num2));
            }
            else if (op == "-")
            {
                output(sub(num1, num2));
            }
            else if (op == "*")
            {
                output(mul(num1, num2));
            }
            else if (op == "/")
            {
                output(div(num1, num2));
            }
            else
            {
                Console.WriteLine("Error: Invalid Operator");
            }
            Console.ReadLine();
        }

        static double input()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        
        static void output(double res)
        {
            Console.WriteLine("The result is: " + res);
        }
        static double add(double num1, double num2)
        {
            return num1 + num2;
        }
        static double sub(double num1, double num2)
        {
            return num1 - num2;
        }
        static double mul(double num1, double num2)
        {
            return num1 * num2;
        }
        static double div(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
