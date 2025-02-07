using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C_.Methods
{
    internal class ReturnMethod
    {
        static void Main(string[] args)
        {
            string name = AskName();
            Console.WriteLine("Hi "+name);
        }

        static string AskName()
        {
            Console.WriteLine("Enter your name?");
            string userName = Console.ReadLine();
            return userName;
        }
    }
}
