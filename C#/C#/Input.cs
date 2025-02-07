using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_
{
    internal class Input
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplier");
            Console.WriteLine("Enter the first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int result = firstNum * secondNum;
            Console.WriteLine("Result is " + result);
        }
    }
}
