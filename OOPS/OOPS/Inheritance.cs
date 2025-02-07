    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Animal  // Base class
    {
        public void Eat()
        {
            Console.WriteLine("This animal eats food.");
        }
    }

    public class Dog : Animal  // Derived class (inherits Animal)
    {
        public void Bark()
        {
            Console.WriteLine("The dog barks.");
        }
    }
}
