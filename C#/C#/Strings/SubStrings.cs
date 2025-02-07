using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Strings
{
    internal class SubStrings
    {
        static void Main(string[] args)
        {
            string name = "Spongebob Squarepants";

            string sponge = name.Substring(0, 6);
            string square = name.Substring(6);
            Console.WriteLine(sponge);
            Console.WriteLine(square);
        }
    }
}
