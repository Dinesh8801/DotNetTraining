using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    internal class FibonacciGenerator
    {
        public static void PrintFibonacci(int n)
        {
            int a = 0, b = 1, temp;
            Console.Write("Fibonacci Series: {0} {1} ", a, b);
            for (int i = 2; i < n; i++)
            {
                temp = a + b;
                Console.Write(temp + " ");
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }
    }
}
