using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        public Complex(int r, int i)
        {
            Real = r;
            Imaginary = i;
        }

        // Overloading the + operator
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public void Display() => Console.WriteLine($"{Real} + {Imaginary}i");
    }
}
