using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Strings
{
    internal class StringMethods
    {
        static void Main(string[] args)
        {
            string name = "Spongebob Squarepants";
            Console.WriteLine(name.Length);
            //int index = name.IndexOf("Spongebob");
            int index = name.IndexOf("b");
            Console.WriteLine(index);
        } 
    }
}
