using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    internal class FactorialCalculator
    {
        public static int CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            return n * CalculateFactorial(n - 1);
        }
    }
}
