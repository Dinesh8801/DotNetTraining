using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Strings
{
    internal class Replace
    {
        static void Main(string[] args)
        {
            string name = "Spongebob Squarepants";
            string pat = name.Replace("Spongebob", "Patrick");

            Console.WriteLine(pat);
        }
    }
}
