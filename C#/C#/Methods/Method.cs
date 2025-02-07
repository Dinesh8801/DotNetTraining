using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.Methods
{
    internal class Method
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            SayHelloUser(name, age);
            SayHello();
        }
        static void SayHello() 
        {
            Console.WriteLine("Hello, World!");
        }
        //method with parameters
        static void SayHelloUser(string nameSent, int age)
        {
            Console.WriteLine("Hello, " + nameSent);
            Console.WriteLine("Your Age " + age);
        }
    }
}
