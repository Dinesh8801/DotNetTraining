using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class AnimalHi
    {
        public void EatHi() => Console.WriteLine("This animal eats food.");
    }

    public class DogHi : AnimalHi
    {
        public void BarkHi() => Console.WriteLine("The dog barks.");
    }

    public class Cat : AnimalHi
    {
        public void Meow() => Console.WriteLine("The cat meows.");
    }
}
