using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Methods
{
    internal class MethodOverloading
    {
        static void Main(string[] args)
        {
            double num1 = 6.1;
            double num2 = 9.1;
            double result = Add(num1,num2);
            Console.WriteLine("The Result is "+result);
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
    }
}
