using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our Cool Calculator!");

            Console.WriteLine("Enter your first number?");
            double first = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your operator? Choose + - * or /");
            string op = Console.ReadLine();

            Console.WriteLine("Enter your second number?");
            double second = Convert.ToDouble(Console.ReadLine());

            double result=0;
            if (op == "+")
            {
                result = first + second;
            }
            else if (op == "-")
            {
                result = first - second;
            }
            else if (op == "*")
            {
                result = first * second;
            }
            else if (op == "/")
            {
                result = first / second;
            }
            Console.WriteLine("The Result is :"+result);
        }
    }
}
